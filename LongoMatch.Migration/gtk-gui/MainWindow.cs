
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.VBox vbox2;
	private global::Gtk.Label label2;
	private global::Gtk.Label label3;
	private global::Gtk.ScrolledWindow scrolledwindow1;
	private global::Gtk.TextView textview1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button button2;
	private global::Gtk.Button button1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Migration tool");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b> We have found the following elements from the old version: </b>");
		this.label2.UseMarkup = true;
		this.vbox2.Add (this.label2);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label2]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Padding = ((uint)(23));
		// Container child vbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.vbox2.Add (this.label3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label3]));
		w2.Position = 1;
		w2.Expand = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.scrolledwindow1.Add (this.textview1);
		this.vbox2.Add (this.scrolledwindow1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scrolledwindow1]));
		w4.Position = 2;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w5.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseStock = true;
		this.button2.UseUnderline = true;
		this.button2.Label = "gtk-close";
		this.hbox1.Add (this.button2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button2]));
		w6.Position = 0;
		w6.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		// Container child button1.Gtk.Container+ContainerChild
		global::Gtk.Alignment w7 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w8 = new global::Gtk.HBox ();
		w8.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w9 = new global::Gtk.Image ();
		w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
		w8.Add (w9);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w11 = new global::Gtk.Label ();
		w11.LabelProp = global::Mono.Unix.Catalog.GetString ("Convert");
		w11.UseUnderline = true;
		w8.Add (w11);
		w7.Add (w8);
		this.button1.Add (w7);
		this.hbox1.Add (this.button1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button1]));
		w15.Position = 1;
		w15.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 664;
		this.DefaultHeight = 285;
		this.scrolledwindow1.Hide ();
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
		this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
	}
}