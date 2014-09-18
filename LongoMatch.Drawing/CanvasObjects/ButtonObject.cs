//
//  Copyright (C) 2014 Andoni Morales Alastruey
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
using LongoMatch.Core.Common;
using LongoMatch.Core.Store.Drawables;
using LongoMatch.Core.Interfaces.Drawing;

namespace LongoMatch.Drawing.CanvasObjects
{
	public class ButtonObject: CanvasButtonObject, IMovableObject
	{
		public virtual Point Position {
			get;
			set;
		}

		public virtual double Width {
			get;
			set;
		}

		public virtual double Height {
			get;
			set;
		}

		public virtual Color BorderColor {
			get;
			set;
		}

		public virtual Color BackgroundColor {
			get;
			set;
		}

		protected Color CurrentBackgroundColor {
			get {
				if (!Active) {
					return BorderColor;
				} else {
					return BackgroundColor;
				}
			}
		}

		public TagMode Mode {
			get;
			set;
		}

		protected Point DrawPosition {
			get {
				if (!Active) {
					return Position;
				} else {
					return new Point (Position.X + 1, Position.Y + 1);
				}
			}
		}

		public Selection GetSelection (Point p, double precision, bool inMotion=false)
		{
			Selection s;

			Rectangle r = new Rectangle (Position, Width, Height);
			s = r.GetSelection (p, precision);
			if (s != null) {
				s.Drawable = this;
				if (s.Position != SelectionPosition.BottomRight &&
					s.Position != SelectionPosition.Right &&
					s.Position != SelectionPosition.Bottom) {
					s.Position = SelectionPosition.All;
				}
			}
			return s;
		}

		public void Move (Selection s, Point p, Point start)
		{
			switch (s.Position) {
			case SelectionPosition.Right:
				Width = (int)(p.X - Position.X);
				Width = (int)Math.Max (10, Width);
				break;
			case SelectionPosition.Bottom:
				Height = (int)(p.Y - Position.Y);
				Height = (int)Math.Max (10, Height);
				break;
			case SelectionPosition.BottomRight:
				Width = (int)(p.X - Position.X);
				Height = (int)(p.Y - Position.Y);
				Width = Math.Max (10, Width);
				Height = Math.Max (10, Height);
				break;
			case SelectionPosition.All:
				Position.X += p.X - start.X;
				Position.Y += p.Y - start.Y;
				Position.X = Math.Max (Position.X, 0);
				Position.Y = Math.Max (Position.Y, 0);
				break;
			default:
				throw new Exception ("Unsupported move for tagger object:  " + s.Position);
			}
		}

		protected void DrawSelectionArea (IDrawingToolkit tk)
		{
			if (!Selected || Mode != TagMode.Edit) {
				return;
			}
			tk.StrokeColor = Constants.SELECTION_INDICATOR_COLOR;
			tk.StrokeColor = Constants.SELECTION_AREA_COLOR;
			tk.FillColor = null;
			tk.LineStyle = LineStyle.Dashed;
			tk.LineWidth = 1;
			tk.DrawRectangle (DrawPosition, Width, Height);

			tk.StrokeColor = tk.FillColor = Constants.SELECTION_INDICATOR_COLOR;
			tk.LineStyle = LineStyle.Normal;
			tk.DrawRectangle (new Point (DrawPosition.X + Width - 3,
			                             DrawPosition.Y + Height - 3),
			                  6, 6);
		}

		protected void DrawButton (IDrawingToolkit tk)
		{
			tk.LineWidth = 0;
			tk.DrawButton (DrawPosition, Width, Height, 3, BorderColor, CurrentBackgroundColor);
		}

		public override void Draw (IDrawingToolkit tk, Area area)
		{
			tk.Begin ();
			tk.End ();
		}
	}
}
