// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Deployment.Gui {
    
    
    internal partial class DeployDialog {
        
        private Gtk.HBox hbox1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Image image2;
        
        private Gtk.Notebook notebook;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label labelTitle;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.Label label1;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView targetsTree;
        
        private Gtk.Label label2;
        
        private Gtk.VBox pageSelectProject;
        
        private Gtk.Label labelTitle1;
        
        private Gtk.HSeparator hseparator4;
        
        private Gtk.Label label4;
        
        private MonoDevelop.Deployment.Gui.EntrySelectionTree entryTree;
        
        private Gtk.Label label3;
        
        private Gtk.VBox vbox4;
        
        private Gtk.Label label5;
        
        private Gtk.HSeparator hseparator3;
        
        private Gtk.EventBox editorBox;
        
        private Gtk.HSeparator saveSeparator;
        
        private Gtk.HBox hbox2;
        
        private Gtk.CheckButton checkSave;
        
        private Gtk.Label label6;
        
        private Gtk.VBox pageSave;
        
        private Gtk.Label label7;
        
        private Gtk.HSeparator hseparator5;
        
        private Gtk.VBox vbox7;
        
        private Gtk.Label label14;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label13;
        
        private Gtk.Entry entrySaveName;
        
        private Gtk.VBox vboxSaveProject;
        
        private Gtk.HSeparator hseparator6;
        
        private Gtk.Label label15;
        
        private Gtk.RadioButton radioCreateProject;
        
        private Gtk.HBox hbox5;
        
        private Gtk.Label label9;
        
        private Gtk.Table tableNewProject;
        
        private Gtk.ComboBox comboCreateProject;
        
        private Gtk.Entry entryProjectName;
        
        private Gtk.Label label11;
        
        private Gtk.Label label16;
        
        private Gtk.RadioButton radioAddProject;
        
        private Gtk.HBox boxAddProject;
        
        private Gtk.Label label10;
        
        private Gtk.Label label12;
        
        private Gtk.ComboBox comboSelProject;
        
        private Gtk.Label label8;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonBack;
        
        private Gtk.Button buttonNext;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Deployment.Gui.DeployDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.Deployment.Gui.DeployDialog";
            this.Title = Mono.Unix.Catalog.GetString("Create Package");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child MonoDevelop.Deployment.Gui.DeployDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            this.hbox1.BorderWidth = ((uint)(6));
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            // Container child vbox2.Gtk.Box+BoxChild
            this.image2 = new Gtk.Image();
            this.image2.Name = "image2";
            this.image2.Pixbuf = Gdk.Pixbuf.LoadFromResource("package-x-generic.png");
            this.vbox2.Add(this.image2);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.image2]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            this.hbox1.Add(this.vbox2);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.notebook = new Gtk.Notebook();
            this.notebook.CanFocus = true;
            this.notebook.Name = "notebook";
            this.notebook.CurrentPage = 0;
            this.notebook.ShowBorder = false;
            this.notebook.BorderWidth = ((uint)(6));
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.labelTitle = new Gtk.Label();
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Xalign = 0F;
            this.labelTitle.LabelProp = Mono.Unix.Catalog.GetString("<big><b>Package Type</b></big>");
            this.labelTitle.UseMarkup = true;
            this.vbox3.Add(this.labelTitle);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox3[this.labelTitle]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.vbox3.Add(this.hseparator2);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.hseparator2]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Select the type of package to create:");
            this.vbox3.Add(this.label1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox3[this.label1]));
            w6.Position = 2;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.VscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow2.HscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.targetsTree = new Gtk.TreeView();
            this.targetsTree.CanFocus = true;
            this.targetsTree.Name = "targetsTree";
            this.scrolledwindow2.Add(this.targetsTree);
            this.vbox3.Add(this.scrolledwindow2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.scrolledwindow2]));
            w8.Position = 3;
            this.notebook.Add(this.vbox3);
            Gtk.Notebook.NotebookChild w9 = ((Gtk.Notebook.NotebookChild)(this.notebook[this.vbox3]));
            w9.TabExpand = false;
            // Notebook tab
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("page5");
            this.notebook.SetTabLabel(this.vbox3, this.label2);
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.pageSelectProject = new Gtk.VBox();
            this.pageSelectProject.Name = "pageSelectProject";
            this.pageSelectProject.Spacing = 6;
            // Container child pageSelectProject.Gtk.Box+BoxChild
            this.labelTitle1 = new Gtk.Label();
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Xalign = 0F;
            this.labelTitle1.LabelProp = Mono.Unix.Catalog.GetString("<big><b>Select Project</b></big>");
            this.labelTitle1.UseMarkup = true;
            this.pageSelectProject.Add(this.labelTitle1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.pageSelectProject[this.labelTitle1]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child pageSelectProject.Gtk.Box+BoxChild
            this.hseparator4 = new Gtk.HSeparator();
            this.hseparator4.Name = "hseparator4";
            this.pageSelectProject.Add(this.hseparator4);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.pageSelectProject[this.hseparator4]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            // Container child pageSelectProject.Gtk.Box+BoxChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 0F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Select the project or solution for which you want to create a package:");
            this.pageSelectProject.Add(this.label4);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.pageSelectProject[this.label4]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            // Container child pageSelectProject.Gtk.Box+BoxChild
            this.entryTree = new MonoDevelop.Deployment.Gui.EntrySelectionTree();
            this.entryTree.Events = ((Gdk.EventMask)(256));
            this.entryTree.Name = "entryTree";
            this.pageSelectProject.Add(this.entryTree);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.pageSelectProject[this.entryTree]));
            w13.Position = 3;
            this.notebook.Add(this.pageSelectProject);
            Gtk.Notebook.NotebookChild w14 = ((Gtk.Notebook.NotebookChild)(this.notebook[this.pageSelectProject]));
            w14.Position = 1;
            w14.TabExpand = false;
            // Notebook tab
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("page3");
            this.notebook.SetTabLabel(this.pageSelectProject, this.label3);
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("<big><b>Package Settings</b></big>");
            this.label5.UseMarkup = true;
            this.vbox4.Add(this.label5);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox4[this.label5]));
            w15.Position = 0;
            w15.Expand = false;
            w15.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hseparator3 = new Gtk.HSeparator();
            this.hseparator3.Name = "hseparator3";
            this.vbox4.Add(this.hseparator3);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox4[this.hseparator3]));
            w16.Position = 1;
            w16.Expand = false;
            w16.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.editorBox = new Gtk.EventBox();
            this.editorBox.Name = "editorBox";
            this.vbox4.Add(this.editorBox);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox4[this.editorBox]));
            w17.Position = 2;
            // Container child vbox4.Gtk.Box+BoxChild
            this.saveSeparator = new Gtk.HSeparator();
            this.saveSeparator.Name = "saveSeparator";
            this.vbox4.Add(this.saveSeparator);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox4[this.saveSeparator]));
            w18.Position = 3;
            w18.Expand = false;
            w18.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.checkSave = new Gtk.CheckButton();
            this.checkSave.CanFocus = true;
            this.checkSave.Name = "checkSave";
            this.checkSave.Label = Mono.Unix.Catalog.GetString("Save this package configuration in the solution");
            this.checkSave.DrawIndicator = true;
            this.checkSave.UseUnderline = true;
            this.hbox2.Add(this.checkSave);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.hbox2[this.checkSave]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            this.vbox4.Add(this.hbox2);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
            w20.Position = 4;
            w20.Expand = false;
            w20.Fill = false;
            this.notebook.Add(this.vbox4);
            Gtk.Notebook.NotebookChild w21 = ((Gtk.Notebook.NotebookChild)(this.notebook[this.vbox4]));
            w21.Position = 2;
            w21.TabExpand = false;
            // Notebook tab
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("page2");
            this.notebook.SetTabLabel(this.vbox4, this.label6);
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.pageSave = new Gtk.VBox();
            this.pageSave.Name = "pageSave";
            this.pageSave.Spacing = 6;
            // Container child pageSave.Gtk.Box+BoxChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("<big><b>Save Package Configuration</b></big>");
            this.label7.UseMarkup = true;
            this.pageSave.Add(this.label7);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.pageSave[this.label7]));
            w22.Position = 0;
            w22.Expand = false;
            w22.Fill = false;
            // Container child pageSave.Gtk.Box+BoxChild
            this.hseparator5 = new Gtk.HSeparator();
            this.hseparator5.Name = "hseparator5";
            this.pageSave.Add(this.hseparator5);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.pageSave[this.hseparator5]));
            w23.Position = 1;
            w23.Expand = false;
            w23.Fill = false;
            // Container child pageSave.Gtk.Box+BoxChild
            this.vbox7 = new Gtk.VBox();
            this.vbox7.Name = "vbox7";
            this.vbox7.Spacing = 6;
            // Container child vbox7.Gtk.Box+BoxChild
            this.label14 = new Gtk.Label();
            this.label14.Name = "label14";
            this.label14.Xalign = 0F;
            this.label14.LabelProp = Mono.Unix.Catalog.GetString("Enter the name you want to give to this package configuration:");
            this.vbox7.Add(this.label14);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox7[this.label14]));
            w24.Position = 0;
            w24.Expand = false;
            w24.Fill = false;
            // Container child vbox7.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label13 = new Gtk.Label();
            this.label13.Name = "label13";
            this.label13.LabelProp = Mono.Unix.Catalog.GetString("Name:");
            this.hbox4.Add(this.label13);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.hbox4[this.label13]));
            w25.Position = 0;
            w25.Expand = false;
            w25.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.entrySaveName = new Gtk.Entry();
            this.entrySaveName.CanFocus = true;
            this.entrySaveName.Name = "entrySaveName";
            this.entrySaveName.IsEditable = true;
            this.entrySaveName.InvisibleChar = '●';
            this.hbox4.Add(this.entrySaveName);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.hbox4[this.entrySaveName]));
            w26.Position = 1;
            this.vbox7.Add(this.hbox4);
            Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.vbox7[this.hbox4]));
            w27.Position = 1;
            w27.Expand = false;
            w27.Fill = false;
            w27.Padding = ((uint)(6));
            // Container child vbox7.Gtk.Box+BoxChild
            this.vboxSaveProject = new Gtk.VBox();
            this.vboxSaveProject.Name = "vboxSaveProject";
            this.vboxSaveProject.Spacing = 6;
            // Container child vboxSaveProject.Gtk.Box+BoxChild
            this.hseparator6 = new Gtk.HSeparator();
            this.hseparator6.Name = "hseparator6";
            this.vboxSaveProject.Add(this.hseparator6);
            Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.vboxSaveProject[this.hseparator6]));
            w28.Position = 0;
            w28.Expand = false;
            w28.Fill = false;
            // Container child vboxSaveProject.Gtk.Box+BoxChild
            this.label15 = new Gtk.Label();
            this.label15.Name = "label15";
            this.label15.Xalign = 0F;
            this.label15.LabelProp = Mono.Unix.Catalog.GetString("Where do you want to save this configuration?");
            this.vboxSaveProject.Add(this.label15);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.vboxSaveProject[this.label15]));
            w29.Position = 1;
            w29.Expand = false;
            w29.Fill = false;
            // Container child vboxSaveProject.Gtk.Box+BoxChild
            this.radioCreateProject = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Save in a new Packaging Project"));
            this.radioCreateProject.CanFocus = true;
            this.radioCreateProject.Name = "radioCreateProject";
            this.radioCreateProject.DrawIndicator = true;
            this.radioCreateProject.UseUnderline = true;
            this.radioCreateProject.Group = new GLib.SList(System.IntPtr.Zero);
            this.vboxSaveProject.Add(this.radioCreateProject);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.vboxSaveProject[this.radioCreateProject]));
            w30.Position = 2;
            w30.Expand = false;
            w30.Fill = false;
            // Container child vboxSaveProject.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.label9 = new Gtk.Label();
            this.label9.WidthRequest = 24;
            this.label9.Name = "label9";
            this.label9.LabelProp = "";
            this.hbox5.Add(this.label9);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.hbox5[this.label9]));
            w31.Position = 0;
            w31.Expand = false;
            w31.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.tableNewProject = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.tableNewProject.Name = "tableNewProject";
            this.tableNewProject.RowSpacing = ((uint)(6));
            this.tableNewProject.ColumnSpacing = ((uint)(6));
            // Container child tableNewProject.Gtk.Table+TableChild
            this.comboCreateProject = Gtk.ComboBox.NewText();
            this.comboCreateProject.Name = "comboCreateProject";
            this.tableNewProject.Add(this.comboCreateProject);
            Gtk.Table.TableChild w32 = ((Gtk.Table.TableChild)(this.tableNewProject[this.comboCreateProject]));
            w32.LeftAttach = ((uint)(1));
            w32.RightAttach = ((uint)(2));
            w32.XOptions = ((Gtk.AttachOptions)(4));
            w32.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableNewProject.Gtk.Table+TableChild
            this.entryProjectName = new Gtk.Entry();
            this.entryProjectName.CanFocus = true;
            this.entryProjectName.Name = "entryProjectName";
            this.entryProjectName.Text = Mono.Unix.Catalog.GetString("Packages");
            this.entryProjectName.IsEditable = true;
            this.entryProjectName.InvisibleChar = '●';
            this.tableNewProject.Add(this.entryProjectName);
            Gtk.Table.TableChild w33 = ((Gtk.Table.TableChild)(this.tableNewProject[this.entryProjectName]));
            w33.TopAttach = ((uint)(1));
            w33.BottomAttach = ((uint)(2));
            w33.LeftAttach = ((uint)(1));
            w33.RightAttach = ((uint)(2));
            w33.XOptions = ((Gtk.AttachOptions)(4));
            w33.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableNewProject.Gtk.Table+TableChild
            this.label11 = new Gtk.Label();
            this.label11.Name = "label11";
            this.label11.Xalign = 0F;
            this.label11.LabelProp = Mono.Unix.Catalog.GetString("Project name:");
            this.tableNewProject.Add(this.label11);
            Gtk.Table.TableChild w34 = ((Gtk.Table.TableChild)(this.tableNewProject[this.label11]));
            w34.TopAttach = ((uint)(1));
            w34.BottomAttach = ((uint)(2));
            w34.XOptions = ((Gtk.AttachOptions)(4));
            w34.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableNewProject.Gtk.Table+TableChild
            this.label16 = new Gtk.Label();
            this.label16.Name = "label16";
            this.label16.LabelProp = Mono.Unix.Catalog.GetString("Create in solution:");
            this.tableNewProject.Add(this.label16);
            Gtk.Table.TableChild w35 = ((Gtk.Table.TableChild)(this.tableNewProject[this.label16]));
            w35.XOptions = ((Gtk.AttachOptions)(4));
            w35.YOptions = ((Gtk.AttachOptions)(4));
            this.hbox5.Add(this.tableNewProject);
            Gtk.Box.BoxChild w36 = ((Gtk.Box.BoxChild)(this.hbox5[this.tableNewProject]));
            w36.Position = 1;
            w36.Expand = false;
            w36.Fill = false;
            this.vboxSaveProject.Add(this.hbox5);
            Gtk.Box.BoxChild w37 = ((Gtk.Box.BoxChild)(this.vboxSaveProject[this.hbox5]));
            w37.Position = 3;
            w37.Expand = false;
            w37.Fill = false;
            // Container child vboxSaveProject.Gtk.Box+BoxChild
            this.radioAddProject = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Add to existing Packaging Project"));
            this.radioAddProject.CanFocus = true;
            this.radioAddProject.Name = "radioAddProject";
            this.radioAddProject.DrawIndicator = true;
            this.radioAddProject.UseUnderline = true;
            this.radioAddProject.Group = this.radioCreateProject.Group;
            this.vboxSaveProject.Add(this.radioAddProject);
            Gtk.Box.BoxChild w38 = ((Gtk.Box.BoxChild)(this.vboxSaveProject[this.radioAddProject]));
            w38.Position = 4;
            w38.Expand = false;
            w38.Fill = false;
            // Container child vboxSaveProject.Gtk.Box+BoxChild
            this.boxAddProject = new Gtk.HBox();
            this.boxAddProject.Name = "boxAddProject";
            this.boxAddProject.Spacing = 6;
            // Container child boxAddProject.Gtk.Box+BoxChild
            this.label10 = new Gtk.Label();
            this.label10.WidthRequest = 24;
            this.label10.Name = "label10";
            this.label10.LabelProp = "";
            this.boxAddProject.Add(this.label10);
            Gtk.Box.BoxChild w39 = ((Gtk.Box.BoxChild)(this.boxAddProject[this.label10]));
            w39.Position = 0;
            w39.Expand = false;
            w39.Fill = false;
            // Container child boxAddProject.Gtk.Box+BoxChild
            this.label12 = new Gtk.Label();
            this.label12.Name = "label12";
            this.label12.LabelProp = Mono.Unix.Catalog.GetString("Project:");
            this.boxAddProject.Add(this.label12);
            Gtk.Box.BoxChild w40 = ((Gtk.Box.BoxChild)(this.boxAddProject[this.label12]));
            w40.Position = 1;
            w40.Expand = false;
            w40.Fill = false;
            // Container child boxAddProject.Gtk.Box+BoxChild
            this.comboSelProject = Gtk.ComboBox.NewText();
            this.comboSelProject.Name = "comboSelProject";
            this.boxAddProject.Add(this.comboSelProject);
            Gtk.Box.BoxChild w41 = ((Gtk.Box.BoxChild)(this.boxAddProject[this.comboSelProject]));
            w41.Position = 2;
            w41.Expand = false;
            w41.Fill = false;
            this.vboxSaveProject.Add(this.boxAddProject);
            Gtk.Box.BoxChild w42 = ((Gtk.Box.BoxChild)(this.vboxSaveProject[this.boxAddProject]));
            w42.Position = 5;
            w42.Expand = false;
            w42.Fill = false;
            this.vbox7.Add(this.vboxSaveProject);
            Gtk.Box.BoxChild w43 = ((Gtk.Box.BoxChild)(this.vbox7[this.vboxSaveProject]));
            w43.Position = 2;
            w43.Expand = false;
            w43.Fill = false;
            this.pageSave.Add(this.vbox7);
            Gtk.Box.BoxChild w44 = ((Gtk.Box.BoxChild)(this.pageSave[this.vbox7]));
            w44.Position = 2;
            w44.Expand = false;
            w44.Fill = false;
            this.notebook.Add(this.pageSave);
            Gtk.Notebook.NotebookChild w45 = ((Gtk.Notebook.NotebookChild)(this.notebook[this.pageSave]));
            w45.Position = 3;
            w45.TabExpand = false;
            // Notebook tab
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("page4");
            this.notebook.SetTabLabel(this.pageSave, this.label8);
            this.hbox1.Add(this.notebook);
            Gtk.Box.BoxChild w46 = ((Gtk.Box.BoxChild)(this.hbox1[this.notebook]));
            w46.Position = 1;
            w1.Add(this.hbox1);
            Gtk.Box.BoxChild w47 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
            w47.Position = 0;
            // Internal child MonoDevelop.Deployment.Gui.DeployDialog.ActionArea
            Gtk.HButtonBox w48 = this.ActionArea;
            w48.Name = "MonoDevelop.Deployment.DeployDialog_ActionArea";
            w48.Spacing = 10;
            w48.BorderWidth = ((uint)(5));
            w48.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child MonoDevelop.Deployment.DeployDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w49 = ((Gtk.ButtonBox.ButtonBoxChild)(w48[this.buttonCancel]));
            w49.Expand = false;
            w49.Fill = false;
            // Container child MonoDevelop.Deployment.DeployDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonBack = new Gtk.Button();
            this.buttonBack.CanDefault = true;
            this.buttonBack.CanFocus = true;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.UseStock = true;
            this.buttonBack.UseUnderline = true;
            this.buttonBack.Label = "gtk-go-back";
            w48.Add(this.buttonBack);
            Gtk.ButtonBox.ButtonBoxChild w50 = ((Gtk.ButtonBox.ButtonBoxChild)(w48[this.buttonBack]));
            w50.Position = 1;
            w50.Expand = false;
            w50.Fill = false;
            // Container child MonoDevelop.Deployment.DeployDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonNext = new Gtk.Button();
            this.buttonNext.CanDefault = true;
            this.buttonNext.CanFocus = true;
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.UseStock = true;
            this.buttonNext.UseUnderline = true;
            this.buttonNext.Label = "gtk-go-forward";
            w48.Add(this.buttonNext);
            Gtk.ButtonBox.ButtonBoxChild w51 = ((Gtk.ButtonBox.ButtonBoxChild)(w48[this.buttonNext]));
            w51.Position = 2;
            w51.Expand = false;
            w51.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 573;
            this.DefaultHeight = 432;
            this.Show();
            this.notebook.SelectPage += new Gtk.SelectPageHandler(this.OnNotebookSelectPage);
            this.checkSave.Clicked += new System.EventHandler(this.OnCheckSaveClicked);
            this.radioCreateProject.Clicked += new System.EventHandler(this.OnRadioCreateProjectClicked);
            this.radioAddProject.Clicked += new System.EventHandler(this.OnRadioAddProjectClicked);
            this.buttonBack.Clicked += new System.EventHandler(this.OnButtonBackClicked);
            this.buttonNext.Clicked += new System.EventHandler(this.OnButtonNextClicked);
        }
    }
}
