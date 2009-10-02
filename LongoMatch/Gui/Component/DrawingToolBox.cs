// 
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
// 
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//  
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
// 

using System;
using Gtk;
using Gdk;
using LongoMatch.Handlers;

namespace LongoMatch.Gui.Component
{
	
	[System.ComponentModel.ToolboxItem(true)] 
	public partial class DrawingToolBox : Gtk.Bin
	{

		public event LineWidthChangedHandler LineWidthChanged;
		public event DrawToolChangedHandler DrawToolChanged;
		public event ColorChangedHandler ColorChanged;
		public event VisibilityChangedHandler VisibilityChanged;
		public event ClearDrawingHandler ClearDrawing;
		public event TransparencyChangedHandler TransparencyChanged;
		
		Gdk.Color normalColor;
		Gdk.Color activeColor;		
		
		public DrawingToolBox()
		{
			this.Build();
			SetButtonColor(wbutton,"white");
			SetButtonColor(bbutton,"black");
			SetButtonColor(rbutton,"red");
			SetButtonColor(gbutton,"green");
			SetButtonColor(blbutton,"blue");
			SetButtonColor(ybutton,"yellow");
			penbutton.Active = true;
			rbutton.Active = true;
		}
		
		public bool DrawingVisibility{
			set{
				if (VisibilityChanged != null)
					VisibilityChanged(value);
			}
		}

		public bool ToolsVisible{
			set{
				toolstable.Visible=value;
				toolslabel.Visible= value;
			}
		}
		
		public bool InfoVisible{
			set{label1.Visible=value;}
		}
		
		private void SetButtonColor(Button button, string color){
			
			string darkColor;
			
			if (color == "yellow")
				darkColor = "goldenrod";
			else if (color == "white")
				darkColor = "beige";
			else if (color == "black")
				darkColor = "black";
			else
				darkColor = "dark "+color;
			
			Gdk.Color.Parse(color,ref normalColor);
			Gdk.Color.Parse(darkColor,ref activeColor);
			button.ModifyBg(StateType.Normal,normalColor);
			button.ModifyBg(StateType.Active,activeColor);
			button.ModifyBg(StateType.Selected,activeColor);
			button.ModifyBg(StateType.Prelight,normalColor);			
		}

		protected virtual void OnCombobox1Changed(object sender, System.EventArgs e)
		{
			int lineWidth;
			if (LineWidthChanged != null){
				lineWidth = Int16.Parse(combobox1.ActiveText.Split(' ')[0]);
				LineWidthChanged(lineWidth);
			}				
		}

		protected virtual void OnButtonToggled (object sender, System.EventArgs e)
		{
			RadioButton button = sender as RadioButton;
			if (ColorChanged != null && button.Active)
				ColorChanged(button.Style.Background(StateType.Normal));
		}

		protected virtual void OnCirclebuttonToggled (object sender, System.EventArgs e)
		{
			if (DrawToolChanged != null && (sender as RadioButton).Active)
				DrawToolChanged(DrawTool.CIRCLE);
		}

		protected virtual void OnRectanglebuttonToggled (object sender, System.EventArgs e)
		{
			if (DrawToolChanged != null && (sender as RadioButton).Active)
				DrawToolChanged(DrawTool.RECTANGLE);
		}

		protected virtual void OnLinebuttonToggled (object sender, System.EventArgs e)
		{
			if (DrawToolChanged != null && (sender as RadioButton).Active)
				DrawToolChanged(DrawTool.LINE);
		}

		protected virtual void OnCrossbuttonToggled (object sender, System.EventArgs e)
		{
			if (DrawToolChanged != null && (sender as RadioButton).Active)
				DrawToolChanged(DrawTool.CROSS);
		}

		protected virtual void OnEraserbuttonToggled (object sender, System.EventArgs e)
		{
			if (DrawToolChanged != null && (sender as RadioButton).Active)
				DrawToolChanged(DrawTool.ERASER);
		}

		protected virtual void OnPenbuttonToggled (object sender, System.EventArgs e)
		{
			if (DrawToolChanged != null && (sender as RadioButton).Active)
				DrawToolChanged(DrawTool.PEN);
		}

		protected virtual void OnClearbuttonClicked (object sender, System.EventArgs e)
		{
			if (ClearDrawing != null)
				ClearDrawing();
		}

		protected virtual void OnSpinbutton1Changed (object sender, System.EventArgs e)
		{
			if (TransparencyChanged != null)
				TransparencyChanged(spinbutton1.Value/100);
		}	
	}
}
