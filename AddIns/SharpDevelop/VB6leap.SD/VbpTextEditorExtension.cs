﻿// This file is part of vb6leap.
// 
// vb6leap is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// vb6leap is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with vb6leap.  If not, see <http://www.gnu.org/licenses/>.

using ICSharpCode.AvalonEdit.Rendering;
using ICSharpCode.SharpDevelop.Editor;
using ICSharpCode.SharpDevelop.Gui;
using VB6leap.SDAddin.Gui;

namespace VB6leap.SDAddin
{
    class VbpTextEditorExtension : ITextEditorExtension
    {
        #region Fields

        private TextView _textView;
        private ModuleOutlineControl _outlineContent;

        #endregion

        #region ITextEditorExtension Members

        void ITextEditorExtension.Attach(ITextEditor editor)
        {
            _outlineContent = new ModuleOutlineControl(editor);

            _textView = editor.GetService(typeof(TextView)) as TextView;
            _textView.Services.AddService(typeof(IOutlineContentHost), _outlineContent);
        }

        void ITextEditorExtension.Detach()
        {
            _textView.Services.RemoveService(typeof(IOutlineContentHost));

            _outlineContent.Dispose();
            _outlineContent = null;
        }

        #endregion
    }
}
