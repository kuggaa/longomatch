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
using LongoMatch.Core.Interfaces.Drawing;
using LongoMatch.Core.Store;
using LongoMatch.Core.Store.Drawables;
using LongoMatch.Drawing.CanvasObjects.Timeline;

namespace LongoMatch.Drawing.Widgets
{
	public class Timerule: SelectionCanvas
	{
		const int BIG_LINE_HEIGHT = 15;
		const int SMALL_LINE_HEIGHT = 5;
		const int TEXT_WIDTH = 20;
		const int TIME_SPACING = 100;
		NeedleObject needle;
		double scroll;
		double secondsPerPixel;
		Time currentTime;

		public Timerule (IWidget widget) : base (widget)
		{
			needle = new NeedleObject ();
			AddObject (needle);
			SecondsPerPixel = 0.1;
			currentTime = new Time (0);
		}

		public double Scroll {
			set {
				scroll = value;
				needle.ResetDrawArea ();
			}
			protected get {
				return scroll;
			}
		}

		public Time Duration {
			set;
			protected get;
		}

		public Time CurrentTime {
			get {
				return currentTime;
			}
			set {
				Area area;
				double start, stop, timeX;

				timeX = Utils.TimeToPos (value, SecondsPerPixel) - Scroll;
				if (needle.X < timeX) {
					start = needle.X;
					stop = timeX;
				} else {
					start = timeX;
					stop = needle.X;
				}
				start -= needle.Width / 2;
				stop += needle.Width / 2;
				area = new Area (new Point (start - 1, needle.TopLeft.Y), stop - start + 2, needle.Height);
				currentTime = value;
				needle.ResetDrawArea ();
				widget.ReDraw (area);
			}
		}

		public double SecondsPerPixel {
			set {
				secondsPerPixel = value;
				needle.ResetDrawArea ();
			}
			get {
				return secondsPerPixel;
			}
		}

		protected override void StartMove (Selection sel)
		{
			Config.EventsBroker.EmitTogglePlayEvent (false);
		}

		protected override void StopMove (bool moved)
		{
			Config.EventsBroker.EmitTogglePlayEvent (true);
		}

		protected override void SelectionMoved (Selection sel)
		{
			Config.EventsBroker.EmitSeekEvent (Utils.PosToTime (new Point (needle.X + Scroll, 0),
				SecondsPerPixel), false);
		}

		public override void Draw (IContext context, Area area)
		{
			int startX, start, stop;
			double tpos, height, width;
			
			if (Duration == null) {
				return;
			}
			
			height = widget.Height;
			width = widget.Width;

			tk.Context = context;
			tk.Begin ();
			tk.Clear (Config.Style.PaletteBackgroundDark);
			
			tk.StrokeColor = Config.Style.PaletteWidgets;
			tk.FillColor = Config.Style.PaletteWidgets;
			tk.LineWidth = Constants.TIMELINE_LINE_WIDTH;
			tk.FontSlant = FontSlant.Normal;
			tk.FontSize = StyleConf.TimelineRuleFontSize;
			tk.DrawLine (new Point (area.Start.X, height),
				new Point (area.Start.X + area.Width, height));

			startX = (int)(area.Start.X + Scroll);
			start = (startX - (startX % TIME_SPACING));
			stop = (int)(startX + area.Width + TIME_SPACING);

			/* Draw big lines each 10 * secondsPerPixel */
			for (int i = start; i <= stop; i += TIME_SPACING) {
				double pos = i - Scroll;
				tk.DrawLine (new Point (pos, height),
					new Point (pos, height - BIG_LINE_HEIGHT));
				tk.DrawText (new Point (pos - TEXT_WIDTH / 2, 2), TEXT_WIDTH, height - BIG_LINE_HEIGHT - 2,
					new Time { TotalSeconds = (int)(i * SecondsPerPixel) }.ToSecondsString ());
			}

			start = (startX - (startX % (TIME_SPACING / 10))) + (TIME_SPACING / 10);
			/* Draw small lines each 1 * secondsPerPixel */
			for (int i = start; i <= stop; i += TIME_SPACING / 10) {
				double pos;
				
				if (i % TIME_SPACING == 0)
					continue;
					
				pos = i - Scroll;
				tk.DrawLine (new Point (pos, height),
					new Point (pos, height - SMALL_LINE_HEIGHT));
			}
			
			/* Draw position triangle */
			needle.TimelineHeight = height;
			if (!Moving) {
				tpos = Utils.TimeToPos (CurrentTime, SecondsPerPixel);
				tpos -= Scroll;
				needle.X = tpos;
			}
			needle.Draw (tk, area);
			tk.End ();
			tk.Context = null;
		}
	}
}

