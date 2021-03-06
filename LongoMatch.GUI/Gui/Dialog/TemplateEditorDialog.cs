// TemplateEditorDialog.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//
using System;
using Gtk;

using LongoMatch.Interfaces;
using LongoMatch.Store;
using LongoMatch.Store.Templates;

namespace LongoMatch.Gui.Dialog
{

	[System.ComponentModel.Category("LongoMatch")]
	[System.ComponentModel.ToolboxItem(false)]
	public abstract partial class TemplateEditorDialog: Gtk.Dialog
	{
		public TemplateEditorDialog()
		{
			this.Build();
		}
		
		public void AddTemplateEditor (Widget w){
			templateeditorbox.Add(w);
			w.Show();
		}
	}
	
	public class TemplateEditorDialog<T, U> : TemplateEditorDialog where T: ITemplate<U> {
		ITemplateWidget<T, U> templateEditor;
		
		public TemplateEditorDialog (ITemplateWidget<T, U> templateEditor) {
			this.templateEditor = templateEditor;
			templateEditor.CanExport = true;
			AddTemplateEditor ((Widget)templateEditor);
			
		}
		
		public bool CanExport {
			set {
				templateEditor.CanExport = value;
			}
		}
		
		public Project Project {
			set{
				templateEditor.Project = value;
			}
			get{
				return templateEditor.Project;
			}
		}
		
		public T Template {
			set {
				templateEditor.Template =value;
			}
			get {
				return templateEditor.Template;
			}
		}

	}
}
