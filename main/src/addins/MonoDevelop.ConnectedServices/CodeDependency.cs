using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using MonoDevelop.Core;
using MonoDevelop.Ide.TypeSystem;

namespace MonoDevelop.ConnectedServices
{
	/// <summary>
	/// A service dependency that represents some code that is added to the project
	/// </summary>
	public abstract class CodeDependency : ConnectedServiceDependency
	{
		/// <summary>
		/// Sets the default timeout for obtaining the compilcation for a project
		/// </summary>
		public static int DefaultCompilationTimeout = 5000;

		readonly Dictionary<string, INamedTypeSymbol> lookupTypes;

		IList<INamedTypeSymbol> allTypes;
		Compilation compilation;
		IList<INamedTypeSymbol> sourceTypes;

		protected CodeDependency (IConnectedService service, string displayName, string [] lookupTypes) : base (service, ConnectedServices.CodeDependencyCategory, displayName)
		{
			this.lookupTypes = new Dictionary<string, INamedTypeSymbol> ();

			foreach (var type in lookupTypes) {
				this.lookupTypes [type] = null;
			}
		}

		/// <summary>
		/// Gets the types defined in source files for the compilation
		/// </summary>
		protected IList<INamedTypeSymbol> SourceTypes {
			get {
				if (this.sourceTypes == null) {
					this.sourceTypes = this.allTypes.Where (t => t.IsDefinedInSource ()).ToList ();
				}

				return this.sourceTypes;
			}
		}

		/// <summary>
		/// Adds the dependency to the project and returns true if the dependency was added to the project
		/// </summary>
		public override async Task<bool> AddToProject (CancellationToken token)
		{
			// TODO: get the code compilation
			if (this.compilation == null) {
				this.compilation = await TypeSystemService.GetCompilationAsync (this.Service.Project).ConfigureAwait (false);

				if (this.compilation == null) {
					LoggingService.LogInternalError ("Could not get compilation object to be able to add code dependency.", null);
					return false;
				}

				this.InitLookupTypes (token, this.lookupTypes.Keys.ToArray ());
			}

			return await this.OnAddToProject(token).ConfigureAwait (false);
		}

		/// <summary>
		/// Performs the task of adding the code to the project
		/// </summary>
		protected abstract Task<bool> OnAddToProject (CancellationToken token);

		/// <summary>
		/// Updates the given method region with the code required for this dependency.
		/// </summary>
		protected virtual void UpdateMethodWithCodeDependency (Location methodRegion)
		{
			if (methodRegion == null)
				return;

			var sourceTree = methodRegion.SourceTree;
			if (sourceTree == null)
				return;

			var proj = this.Service.Project.GetCodeAnalysisProject ();
			if (proj == null) {
				// this can happen if the TypeSystemService doesn't have the project in it (yet?)
				LoggingService.LogWarning ("Could not get CodeAnalysisProject for the given project, cannot add code");
				return;
			}

			var docID = proj.GetDocumentId (sourceTree);
			var root = sourceTree.GetRoot ();

			var methodNode = root.FindNode (methodRegion.SourceSpan) as MethodDeclarationSyntax;
			if (methodNode == null)
				return;

			var newMethodNode = this.RemoveExistingCodeDependencyFromMethod (methodNode);
			var newMethodStatements = newMethodNode.Body.Statements;

			var codeStatements = this.CreateCodeDependencyStatements ();
			for (int i = 0; i < codeStatements.Count; i++) {
				newMethodStatements = newMethodStatements.Insert (i, codeStatements [i]);
			}

			newMethodNode = newMethodNode.WithBody (newMethodNode.Body.WithStatements (newMethodStatements));

			if (newMethodNode != methodNode) {
				var newRoot = root.ReplaceNode<SyntaxNode> (methodNode, newMethodNode);

				newRoot = Formatter.Format (newRoot, proj.Solution.Workspace);

				var newSolution = proj.Solution.WithDocumentSyntaxRoot (docID, newRoot);
				proj.Solution.Workspace.TryApplyChanges (newSolution);
			}
		}

		/// <summary>
		/// Adds a method created by newMethod to the param name="classRegion", the newMethod should contain the required code dependency
		/// </summary>
		protected void AddMethodWithCodeDependencyToClass (Location classRegion, Func<MethodDeclarationSyntax> newMethod)
		{
			if (classRegion == null)
				return;

			var sourceTree = classRegion.SourceTree;
			if (sourceTree == null)
				return;

			var proj = this.Service.Project.GetCodeAnalysisProject ();
			var docID = proj.GetDocumentId (sourceTree);
			var root = sourceTree.GetRoot ();

			var classNode = root.FindNode (classRegion.SourceSpan) as ClassDeclarationSyntax;
			if (classNode == null)
				return;

			var newClassNode = classNode;

			newClassNode = newClassNode.WithMembers (newClassNode.Members.Add (newMethod ()));

			if (newClassNode != classNode) {
				var newRoot = root.ReplaceNode<SyntaxNode> (classNode, newClassNode);

				newRoot = Formatter.Format (newRoot, proj.Solution.Workspace);

				var newSolution = proj.Solution.WithDocumentSyntaxRoot (docID, newRoot);
				proj.Solution.Workspace.TryApplyChanges (newSolution);
			}
		}

		/// <summary>
		/// Create the code statements that are required for this code dependency
		/// </summary>
		protected virtual SyntaxList<StatementSyntax> CreateCodeDependencyStatements ()
		{
			return new SyntaxList<StatementSyntax> ();
		}

		/// <summary>
		/// Removes any existing code that was added previously for this dependency
		/// </summary>
		protected virtual MethodDeclarationSyntax RemoveExistingCodeDependencyFromMethod (MethodDeclarationSyntax method)
		{
			var statements = method.Body.Statements;
			var newStatements = statements;
			foreach (var statement in statements) {
				if (this.IsCodeDependencyStatement (statement)) {
					newStatements = newStatements.Remove (statement);
				}
			}

			return method.WithBody (method.Body.WithStatements (newStatements));
		}

		/// <summary>
		/// Returns true if the given statement is (or is part of) the code dependency.
		/// Override this to be able to update added code.
		/// </summary>
		protected virtual bool IsCodeDependencyStatement (StatementSyntax statement)
		{
			return false;
		}

		/// <summary>
		/// Searches the type lookup tabvle for the given type
		/// </summary>
		protected INamedTypeSymbol GetLookupType (string typeName)
		{
			if (this.lookupTypes.ContainsKey (typeName)) {
				return this.lookupTypes [typeName];
			}

			return null;
		}

		/// <summary>
		/// Returns true if the given type is a derived class of 'param name="class"' and has an attribute of type 'param name="attributeType"' applied
		/// </summary>
		protected bool IsAttributedSubclass (INamedTypeSymbol type, string classType, string attributeType)
		{
			return type.IsAttributedSubclass (this.GetLookupType (classType), this.GetLookupType (attributeType));
		}

		/// <summary>
		/// Returns true if the given type has an attribute of type 'param name="attributeType"' applied
		/// </summary>
		protected bool IsAttributed (INamedTypeSymbol type, string attributeType)
		{
			return type.IsAttributed (this.GetLookupType (attributeType));
		}

		/// <summary>
		/// Returns the list of members for a type that are defined in source.
		/// </summary>
		protected IList<ISymbol> GetMembersDefinedInSource (INamedTypeSymbol type)
		{
			return type.GetMembers ().Where (m => m.IsDefinedInSource ()).ToList ();
		}

		/// <summary>
		/// Initializes the type lookup table from the compilation.
		/// </summary>
		void InitLookupTypes (CancellationToken cancel, string [] types)
		{
			this.allTypes = this.compilation.GetAllTypesInMainAssembly (cancel).ToList ();

			foreach (var type in types) {
				this.lookupTypes [type] = this.compilation.GetTypeByMetadataName (type);
			}
		}
	}
}