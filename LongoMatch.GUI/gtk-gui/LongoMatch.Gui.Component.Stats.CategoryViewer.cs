
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component.Stats
{
	public partial class CategoryViewer
	{
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.VBox vbox1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Frame allframe;
		private global::Gtk.Alignment GtkAlignment2;
		private global::LongoMatch.Gui.Component.PlaysCoordinatesTagger alltagger;
		private global::Gtk.Label GtkLabel2;
		private global::Gtk.Frame homeframe;
		private global::Gtk.Alignment GtkAlignment;
		private global::LongoMatch.Gui.Component.PlaysCoordinatesTagger hometagger;
		private global::Gtk.Label homeLabel;
		private global::Gtk.Frame awayframe;
		private global::Gtk.Alignment GtkAlignment1;
		private global::LongoMatch.Gui.Component.PlaysCoordinatesTagger awaytagger;
		private global::Gtk.Label awayLabel;
		private global::Gtk.Label nodatalabel;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.Stats.CategoryViewer
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.Stats.CategoryViewer";
			// Container child LongoMatch.Gui.Component.Stats.CategoryViewer.Gtk.Container+ContainerChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.allframe = new global::Gtk.Frame ();
			this.allframe.Name = "allframe";
			this.allframe.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child allframe.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.alltagger = new global::LongoMatch.Gui.Component.PlaysCoordinatesTagger ();
			this.alltagger.Events = ((global::Gdk.EventMask)(256));
			this.alltagger.Name = "alltagger";
			this.GtkAlignment2.Add (this.alltagger);
			this.allframe.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>All</b>");
			this.GtkLabel2.UseMarkup = true;
			this.allframe.LabelWidget = this.GtkLabel2;
			this.hbox1.Add (this.allframe);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.allframe]));
			w4.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.homeframe = new global::Gtk.Frame ();
			this.homeframe.Name = "homeframe";
			this.homeframe.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child homeframe.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hometagger = new global::LongoMatch.Gui.Component.PlaysCoordinatesTagger ();
			this.hometagger.Events = ((global::Gdk.EventMask)(256));
			this.hometagger.Name = "hometagger";
			this.GtkAlignment.Add (this.hometagger);
			this.homeframe.Add (this.GtkAlignment);
			this.homeLabel = new global::Gtk.Label ();
			this.homeLabel.Name = "homeLabel";
			this.homeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Home</b>");
			this.homeLabel.UseMarkup = true;
			this.homeframe.LabelWidget = this.homeLabel;
			this.hbox1.Add (this.homeframe);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.homeframe]));
			w7.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.awayframe = new global::Gtk.Frame ();
			this.awayframe.Name = "awayframe";
			this.awayframe.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child awayframe.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.awaytagger = new global::LongoMatch.Gui.Component.PlaysCoordinatesTagger ();
			this.awaytagger.Events = ((global::Gdk.EventMask)(256));
			this.awaytagger.Name = "awaytagger";
			this.GtkAlignment1.Add (this.awaytagger);
			this.awayframe.Add (this.GtkAlignment1);
			this.awayLabel = new global::Gtk.Label ();
			this.awayLabel.Name = "awayLabel";
			this.awayLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Away</b>");
			this.awayLabel.UseMarkup = true;
			this.awayframe.LabelWidget = this.awayLabel;
			this.hbox1.Add (this.awayframe);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.awayframe]));
			w10.Position = 2;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w11.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.nodatalabel = new global::Gtk.Label ();
			this.nodatalabel.Name = "nodatalabel";
			this.nodatalabel.LabelProp = global::Mono.Unix.Catalog.GetString ("No data available");
			this.nodatalabel.Justify = ((global::Gtk.Justification)(2));
			this.vbox1.Add (this.nodatalabel);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.nodatalabel]));
			w12.Position = 1;
			w1.Add (this.vbox1);
			this.scrolledwindow1.Add (w1);
			this.Add (this.scrolledwindow1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
