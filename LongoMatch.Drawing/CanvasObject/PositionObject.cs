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
using LongoMatch.Interfaces.Drawing;
using LongoMatch.Store.Drawables;
using LongoMatch.Common;
using LongoMatch.Store;
using LongoMatch.Interfaces;
using System.Collections.Generic;

namespace LongoMatch.Drawing.CanvasObject
{

	public class PositionObject:  BaseCanvasObject, ICanvasSelectableObject
	{

		public PositionObject (List<Point> points, int width, int height)
		{
			Points = points;
			Width = width;
			Height = height;
		}
		
		public int Width {
			get;
			set;
		}
		
		public int Height {
			get;
			set;
		}
		
		public Play Play {
			get;
			set;
		}
		
		public List<Point> Points {
			get;
			set;
		}
		
		Point Start {
			get {
				return Points[0].Denormalize (Width, Height);
			}
			set{
				Points[0] = value.Normalize (Width, Height);
			}
		}
		
		Point Stop {
			get {
				return Points[1].Denormalize (Width, Height);
			}
			set {
				Points[1] = value.Normalize (Width, Height);
			}
		}
		
		
		public Selection GetSelection (Point point, double precision)
		{
			if (point.Distance (Start) < precision) {
				return new Selection (this, SelectionPosition.LineStart);
			} else if (Points.Count == 2 && point.Distance (Stop) < precision) {
				return new Selection (this, SelectionPosition.LineStop);
			}
			return null;
		}
		
		public void Move (Selection sel, Point p, Point start)
		{
			switch (sel.Position) {
			case SelectionPosition.LineStart:
				Start = p;
				break;
			case SelectionPosition.LineStop:
				Stop = p;
				break;
			default:
				throw new Exception ("Unsupported move for circle:  " + sel.Position);
			}
		}
		
		public override void Draw (IDrawingToolkit tk, Area area) {
			Color color;
			
			tk.Begin ();
			if (Play != null) {
				color = Play.Category.Color;
			} else {
				color = Common.TAGGER_POINT_COLOR;
			}
			tk.FillColor = color;
			tk.StrokeColor = color;
			tk.LineWidth = 2;
			
			tk.DrawCircle (Start, Common.TAGGER_POINT_SIZE);
			if (Points.Count == 2) {
				tk.DrawLine (Start, Stop);
			}
			tk.End ();
		}
	}
}
