
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class GameDescriptionHeader
	{
		private global::Gtk.HBox descbox;
		
		private global::Gtk.Image homeimage;
		
		private global::Gtk.VSeparator vseparator1;
		
		private global::Gtk.Label homenamelabel;
		
		private global::Gtk.EventBox homescoreeventbox;
		
		private global::Gtk.Label homescorelabel;
		
		private global::Gtk.EventBox awayscoreeventbox;
		
		private global::Gtk.Label awayscorelabel;
		
		private global::Gtk.Label awaynamelabel;
		
		private global::Gtk.VSeparator vseparator2;
		
		private global::Gtk.Image awayimage;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.GameDescriptionHeader
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.GameDescriptionHeader";
			// Container child LongoMatch.Gui.Component.GameDescriptionHeader.Gtk.Container+ContainerChild
			this.descbox = new global::Gtk.HBox ();
			this.descbox.Name = "descbox";
			this.descbox.Spacing = 6;
			// Container child descbox.Gtk.Box+BoxChild
			this.homeimage = new global::Gtk.Image ();
			this.homeimage.Name = "homeimage";
			this.descbox.Add (this.homeimage);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.descbox [this.homeimage]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator ();
			this.vseparator1.Name = "vseparator1";
			this.descbox.Add (this.vseparator1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.descbox [this.vseparator1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.homenamelabel = new global::Gtk.Label ();
			this.homenamelabel.Name = "homenamelabel";
			this.homenamelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Home");
			this.descbox.Add (this.homenamelabel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.descbox [this.homenamelabel]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.homescoreeventbox = new global::Gtk.EventBox ();
			this.homescoreeventbox.Name = "homescoreeventbox";
			// Container child homescoreeventbox.Gtk.Container+ContainerChild
			this.homescorelabel = new global::Gtk.Label ();
			this.homescorelabel.Name = "homescorelabel";
			this.homescorelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.homescoreeventbox.Add (this.homescorelabel);
			this.descbox.Add (this.homescoreeventbox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.descbox [this.homescoreeventbox]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.awayscoreeventbox = new global::Gtk.EventBox ();
			this.awayscoreeventbox.Name = "awayscoreeventbox";
			// Container child awayscoreeventbox.Gtk.Container+ContainerChild
			this.awayscorelabel = new global::Gtk.Label ();
			this.awayscorelabel.Name = "awayscorelabel";
			this.awayscorelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.awayscoreeventbox.Add (this.awayscorelabel);
			this.descbox.Add (this.awayscoreeventbox);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.descbox [this.awayscoreeventbox]));
			w7.Position = 4;
			w7.Expand = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.awaynamelabel = new global::Gtk.Label ();
			this.awaynamelabel.Name = "awaynamelabel";
			this.awaynamelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Away");
			this.descbox.Add (this.awaynamelabel);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.descbox [this.awaynamelabel]));
			w8.Position = 5;
			w8.Expand = false;
			w8.Fill = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator ();
			this.vseparator2.Name = "vseparator2";
			this.descbox.Add (this.vseparator2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.descbox [this.vseparator2]));
			w9.Position = 6;
			w9.Expand = false;
			w9.Fill = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.awayimage = new global::Gtk.Image ();
			this.awayimage.Name = "awayimage";
			this.descbox.Add (this.awayimage);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.descbox [this.awayimage]));
			w10.Position = 7;
			w10.Fill = false;
			this.Add (this.descbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
