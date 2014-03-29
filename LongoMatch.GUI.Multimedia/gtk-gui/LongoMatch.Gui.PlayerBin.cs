
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui
{
	public partial class PlayerBin
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox mainbox;
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox videobox;
		private global::Gtk.HBox hbox2;
		private global::Gtk.EventBox videoeventbox;
		private global::Gtk.DrawingArea videodrawingarea;
		private global::Gtk.VBox vbox5;
		private global::Gtk.VScale vscale1;
		private global::Gtk.HBox controlsbox;
		private global::Gtk.HBox buttonsbox;
		private global::Gtk.Button closebutton;
		private global::Gtk.Button drawbutton;
		private global::Gtk.Button playbutton;
		private global::Gtk.Button pausebutton;
		private global::Gtk.Button prevbutton;
		private global::Gtk.Button nextbutton;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label jumplabel;
		private global::Gtk.SpinButton jumpspinbutton;
		private global::Gtk.Label tlabel;
		private global::Gtk.HScale timescale;
		private global::Gtk.Label timelabel;
		private global::Gtk.Button volumebutton;
		private global::Gtk.Button detachbutton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.PlayerBin
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.PlayerBin";
			// Container child LongoMatch.Gui.PlayerBin.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.mainbox = new global::Gtk.HBox ();
			this.mainbox.Name = "mainbox";
			this.mainbox.Spacing = 6;
			// Container child mainbox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.videobox = new global::Gtk.HBox ();
			this.videobox.Name = "videobox";
			this.videobox.Spacing = 6;
			// Container child videobox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.videoeventbox = new global::Gtk.EventBox ();
			this.videoeventbox.Name = "videoeventbox";
			// Container child videoeventbox.Gtk.Container+ContainerChild
			this.videodrawingarea = new global::Gtk.DrawingArea ();
			this.videodrawingarea.Name = "videodrawingarea";
			this.videoeventbox.Add (this.videodrawingarea);
			this.hbox2.Add (this.videoeventbox);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.videoeventbox]));
			w2.Position = 0;
			this.videobox.Add (this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.videobox [this.hbox2]));
			w3.Position = 0;
			this.vbox2.Add (this.videobox);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.videobox]));
			w4.Position = 0;
			this.mainbox.Add (this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.mainbox [this.vbox2]));
			w5.Position = 0;
			// Container child mainbox.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vscale1 = new global::Gtk.VScale (null);
			this.vscale1.WidthRequest = 30;
			this.vscale1.Sensitive = false;
			this.vscale1.Name = "vscale1";
			this.vscale1.UpdatePolicy = ((global::Gtk.UpdateType)(1));
			this.vscale1.Inverted = true;
			this.vscale1.Adjustment.Lower = 1;
			this.vscale1.Adjustment.Upper = 30;
			this.vscale1.Adjustment.PageIncrement = 3;
			this.vscale1.Adjustment.PageSize = 1;
			this.vscale1.Adjustment.StepIncrement = 1;
			this.vscale1.Adjustment.Value = 25;
			this.vscale1.DrawValue = true;
			this.vscale1.Digits = 0;
			this.vscale1.ValuePos = ((global::Gtk.PositionType)(3));
			this.vbox5.Add (this.vscale1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vscale1]));
			w6.Position = 0;
			this.mainbox.Add (this.vbox5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.mainbox [this.vbox5]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox3.Add (this.mainbox);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.mainbox]));
			w8.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.controlsbox = new global::Gtk.HBox ();
			this.controlsbox.Name = "controlsbox";
			this.controlsbox.Spacing = 6;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.buttonsbox = new global::Gtk.HBox ();
			this.buttonsbox.Name = "buttonsbox";
			this.buttonsbox.Homogeneous = true;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.closebutton = new global::Gtk.Button ();
			this.closebutton.Name = "closebutton";
			this.closebutton.UseUnderline = true;
			// Container child closebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w9 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w10 = new global::Gtk.HBox ();
			w10.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w11 = new global::Gtk.Image ();
			w11.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-close", global::Gtk.IconSize.Dnd);
			w10.Add (w11);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w13 = new global::Gtk.Label ();
			w10.Add (w13);
			w9.Add (w10);
			this.closebutton.Add (w9);
			this.buttonsbox.Add (this.closebutton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.closebutton]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.drawbutton = new global::Gtk.Button ();
			this.drawbutton.Name = "drawbutton";
			this.drawbutton.UseUnderline = true;
			this.drawbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child drawbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w18 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w19 = new global::Gtk.HBox ();
			w19.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w20 = new global::Gtk.Image ();
			w20.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-select-color", global::Gtk.IconSize.Menu);
			w19.Add (w20);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w22 = new global::Gtk.Label ();
			w19.Add (w22);
			w18.Add (w19);
			this.drawbutton.Add (w18);
			this.buttonsbox.Add (this.drawbutton);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.drawbutton]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.playbutton = new global::Gtk.Button ();
			this.playbutton.Name = "playbutton";
			this.playbutton.UseUnderline = true;
			this.playbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child playbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w27 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w28 = new global::Gtk.HBox ();
			w28.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w29 = new global::Gtk.Image ();
			w29.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-play", global::Gtk.IconSize.Button);
			w28.Add (w29);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w31 = new global::Gtk.Label ();
			w28.Add (w31);
			w27.Add (w28);
			this.playbutton.Add (w27);
			this.buttonsbox.Add (this.playbutton);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.playbutton]));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.pausebutton = new global::Gtk.Button ();
			this.pausebutton.Name = "pausebutton";
			this.pausebutton.UseUnderline = true;
			this.pausebutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child pausebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w36 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w37 = new global::Gtk.HBox ();
			w37.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w38 = new global::Gtk.Image ();
			w38.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-pause", global::Gtk.IconSize.Button);
			w37.Add (w38);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w40 = new global::Gtk.Label ();
			w37.Add (w40);
			w36.Add (w37);
			this.pausebutton.Add (w36);
			this.buttonsbox.Add (this.pausebutton);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.pausebutton]));
			w44.Position = 3;
			w44.Expand = false;
			w44.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.prevbutton = new global::Gtk.Button ();
			this.prevbutton.Name = "prevbutton";
			this.prevbutton.UseUnderline = true;
			this.prevbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child prevbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w45 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w46 = new global::Gtk.HBox ();
			w46.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w47 = new global::Gtk.Image ();
			w47.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-previous", global::Gtk.IconSize.Button);
			w46.Add (w47);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w49 = new global::Gtk.Label ();
			w46.Add (w49);
			w45.Add (w46);
			this.prevbutton.Add (w45);
			this.buttonsbox.Add (this.prevbutton);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.prevbutton]));
			w53.Position = 4;
			w53.Expand = false;
			w53.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.nextbutton = new global::Gtk.Button ();
			this.nextbutton.Sensitive = false;
			this.nextbutton.Name = "nextbutton";
			this.nextbutton.UseUnderline = true;
			this.nextbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child nextbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w54 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w55 = new global::Gtk.HBox ();
			w55.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w56 = new global::Gtk.Image ();
			w56.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-next", global::Gtk.IconSize.Button);
			w55.Add (w56);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w58 = new global::Gtk.Label ();
			w55.Add (w58);
			w54.Add (w55);
			this.nextbutton.Add (w54);
			this.buttonsbox.Add (this.nextbutton);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.nextbutton]));
			w62.Position = 5;
			w62.Expand = false;
			w62.Fill = false;
			this.controlsbox.Add (this.buttonsbox);
			global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.buttonsbox]));
			w63.Position = 0;
			w63.Expand = false;
			w63.Fill = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.jumplabel = new global::Gtk.Label ();
			this.jumplabel.Name = "jumplabel";
			this.jumplabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Jump (s):");
			this.hbox1.Add (this.jumplabel);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.jumplabel]));
			w64.Position = 0;
			w64.Expand = false;
			w64.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.jumpspinbutton = new global::Gtk.SpinButton (1, 100, 1);
			this.jumpspinbutton.TooltipMarkup = "Jump in seconds. Hold the Shift key with the direction keys to activate it.";
			this.jumpspinbutton.Name = "jumpspinbutton";
			this.jumpspinbutton.Adjustment.PageIncrement = 10;
			this.jumpspinbutton.ClimbRate = 1;
			this.jumpspinbutton.Numeric = true;
			this.jumpspinbutton.Value = 10;
			this.hbox1.Add (this.jumpspinbutton);
			global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.jumpspinbutton]));
			w65.Position = 1;
			w65.Expand = false;
			w65.Fill = false;
			this.controlsbox.Add (this.hbox1);
			global::Gtk.Box.BoxChild w66 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.hbox1]));
			w66.Position = 1;
			w66.Expand = false;
			w66.Fill = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.tlabel = new global::Gtk.Label ();
			this.tlabel.Name = "tlabel";
			this.tlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Time:");
			this.controlsbox.Add (this.tlabel);
			global::Gtk.Box.BoxChild w67 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.tlabel]));
			w67.Position = 2;
			w67.Expand = false;
			w67.Fill = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.timescale = new global::Gtk.HScale (null);
			this.timescale.Name = "timescale";
			this.timescale.UpdatePolicy = ((global::Gtk.UpdateType)(1));
			this.timescale.Adjustment.Upper = 1;
			this.timescale.Adjustment.PageIncrement = 1;
			this.timescale.Adjustment.StepIncrement = 1;
			this.timescale.Adjustment.Value = 1;
			this.timescale.DrawValue = false;
			this.timescale.Digits = 0;
			this.timescale.ValuePos = ((global::Gtk.PositionType)(2));
			this.controlsbox.Add (this.timescale);
			global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.timescale]));
			w68.Position = 3;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.timelabel = new global::Gtk.Label ();
			this.timelabel.Name = "timelabel";
			this.controlsbox.Add (this.timelabel);
			global::Gtk.Box.BoxChild w69 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.timelabel]));
			w69.Position = 4;
			w69.Expand = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.volumebutton = new global::Gtk.Button ();
			this.volumebutton.Name = "volumebutton";
			this.volumebutton.UseUnderline = true;
			this.volumebutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child volumebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w70 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w71 = new global::Gtk.HBox ();
			w71.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w72 = new global::Gtk.Image ();
			w72.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_volume", global::Gtk.IconSize.Button);
			w71.Add (w72);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w74 = new global::Gtk.Label ();
			w71.Add (w74);
			w70.Add (w71);
			this.volumebutton.Add (w70);
			this.controlsbox.Add (this.volumebutton);
			global::Gtk.Box.BoxChild w78 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.volumebutton]));
			w78.Position = 5;
			w78.Expand = false;
			w78.Fill = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.detachbutton = new global::Gtk.Button ();
			this.detachbutton.Name = "detachbutton";
			this.detachbutton.UseUnderline = true;
			this.detachbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child detachbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w79 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w80 = new global::Gtk.HBox ();
			w80.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w81 = new global::Gtk.Image ();
			w81.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-disconnect", global::Gtk.IconSize.Menu);
			w80.Add (w81);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w83 = new global::Gtk.Label ();
			w80.Add (w83);
			w79.Add (w80);
			this.detachbutton.Add (w79);
			this.controlsbox.Add (this.detachbutton);
			global::Gtk.Box.BoxChild w87 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.detachbutton]));
			w87.Position = 6;
			w87.Expand = false;
			w87.Fill = false;
			this.vbox3.Add (this.controlsbox);
			global::Gtk.Box.BoxChild w88 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.controlsbox]));
			w88.Position = 1;
			w88.Expand = false;
			w88.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.closebutton.Hide ();
			this.prevbutton.Hide ();
			this.nextbutton.Hide ();
			this.controlsbox.Hide ();
			this.Show ();
			this.vscale1.FormatValue += new global::Gtk.FormatValueHandler (this.OnVscale1FormatValue);
			this.vscale1.ValueChanged += new global::System.EventHandler (this.OnVscale1ValueChanged);
			this.closebutton.Clicked += new global::System.EventHandler (this.OnClosebuttonClicked);
			this.drawbutton.Clicked += new global::System.EventHandler (this.OnDrawButtonClicked);
			this.playbutton.Clicked += new global::System.EventHandler (this.OnPlaybuttonClicked);
			this.pausebutton.Clicked += new global::System.EventHandler (this.OnPausebuttonClicked);
			this.prevbutton.Clicked += new global::System.EventHandler (this.OnPrevbuttonClicked);
			this.nextbutton.Clicked += new global::System.EventHandler (this.OnNextbuttonClicked);
			this.timescale.ValueChanged += new global::System.EventHandler (this.OnTimescaleValueChanged);
			this.timescale.AdjustBounds += new global::Gtk.AdjustBoundsHandler (this.OnTimescaleAdjustBounds);
			this.volumebutton.Clicked += new global::System.EventHandler (this.OnVolumebuttonClicked);
		}
	}
}
