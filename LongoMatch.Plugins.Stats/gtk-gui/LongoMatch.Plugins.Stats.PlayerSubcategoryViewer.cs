
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Plugins.Stats
{
	public partial class PlayerSubcategoryViewer
	{
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.HBox hbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeview;
		private global::LongoMatch.Plugins.Stats.Plotter plotter1;
		private global::Gtk.Label gtkframe;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Plugins.Stats.PlayerSubcategoryViewer
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Plugins.Stats.PlayerSubcategoryViewer";
			// Container child LongoMatch.Plugins.Stats.PlayerSubcategoryViewer.Gtk.Container+ContainerChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview = new global::Gtk.TreeView ();
			this.treeview.CanFocus = true;
			this.treeview.Name = "treeview";
			this.GtkScrolledWindow.Add (this.treeview);
			this.hbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.plotter1 = new global::LongoMatch.Plugins.Stats.Plotter ();
			this.plotter1.Events = ((global::Gdk.EventMask)(256));
			this.plotter1.Name = "plotter1";
			this.hbox1.Add (this.plotter1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.plotter1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.GtkAlignment.Add (this.hbox1);
			this.frame2.Add (this.GtkAlignment);
			this.gtkframe = new global::Gtk.Label ();
			this.gtkframe.Name = "gtkframe";
			this.gtkframe.LabelProp = global::Mono.Unix.Catalog.GetString ("<b></b>");
			this.gtkframe.UseMarkup = true;
			this.frame2.LabelWidget = this.gtkframe;
			this.Add (this.frame2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}