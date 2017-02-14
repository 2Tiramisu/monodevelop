// 
// PlatformFactory.cs
//  
// Author:
//       David Pugh <dpugh@microsoft.com>
// 
// Copyright (c) 2007 Novell, Inc (http://www.novell.com)
// Copyright (c) 2012 Xamarin Inc. (http://xamarin.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using System.ComponentModel.Composition;

namespace Microsoft.VisualStudio.Platform
{
    [Export(typeof(IPlatformAdapterService))]
    public class PlatformAdapterServiceImpl : IPlatformAdapterService
    {
        public ITextBuffer GetPlatformTextBuffer(MonoDevelop.Ide.Editor.TextEditor textEditor)
        {
            return PlatformAdapterService.GetPlatformTextBuffer(textEditor);
        }

        public MonoDevelop.Ide.Editor.ITextDocument GetTextEditor(ITextBuffer textBuffer)
        {
            return PlatformAdapterService.GetTextEditor(textBuffer);
        }

        public ITextView GetPlatformTextView(MonoDevelop.Ide.Editor.TextEditor textEditor)
        {
            return PlatformAdapterService.GetPlatformTextView(textEditor);
        }

        public MonoDevelop.Ide.Editor.TextEditor GetTextEditor(ITextView textView)
        {
            return PlatformAdapterService.GetTextEditor(textView);
        }
    }

    public static class PlatformAdapterService
    { 
        public static ITextBuffer GetPlatformTextBuffer(this MonoDevelop.Ide.Editor.TextEditor textEditor)
        {
            return textEditor.GetContent<Mono.TextEditor.ITextEditorDataProvider>().GetTextEditorData().Document.TextBuffer;
        }

        public static MonoDevelop.Ide.Editor.ITextDocument GetTextEditor(this ITextBuffer textBuffer)
        {
            return textBuffer.Properties.GetProperty<MonoDevelop.Ide.Editor.ITextDocument>(typeof(MonoDevelop.Ide.Editor.ITextDocument));
        }

        public static ITextView GetPlatformTextView(this MonoDevelop.Ide.Editor.TextEditor textEditor)
        {
            return null;
        }

        public static MonoDevelop.Ide.Editor.TextEditor GetTextEditor(this ITextView textView)
        {
            return textView.Properties.GetProperty<MonoDevelop.Ide.Editor.TextEditor>(typeof(MonoDevelop.Ide.Editor.TextEditor));
        }

    }
}