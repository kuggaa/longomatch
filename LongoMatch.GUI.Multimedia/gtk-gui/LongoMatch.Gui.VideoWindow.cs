
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui
{
	public partial class VideoWindow
	{
		private global::Gtk.HBox totalbox;
		
		private global::Gtk.EventBox videoeventbox;
		
		private global::Gtk.Label messageLabel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.VideoWindow
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.VideoWindow";
			// Container child LongoMatch.Gui.VideoWindow.Gtk.Container+ContainerChild
			this.totalbox = new global::Gtk.HBox ();
			this.totalbox.Name = "totalbox";
			// Container child totalbox.Gtk.Box+BoxChild
			this.videoeventbox = new global::Gtk.EventBox ();
			this.videoeventbox.Name = "videoeventbox";
			this.totalbox.Add (this.videoeventbox);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.totalbox [this.videoeventbox]));
			w1.Position = 0;
			// Container child totalbox.Gtk.Box+BoxChild
			this.messageLabel = new global::Gtk.Label ();
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Out of scope");
			this.totalbox.Add (this.messageLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.totalbox [this.messageLabel]));
			w2.Position = 1;
			this.Add (this.totalbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
