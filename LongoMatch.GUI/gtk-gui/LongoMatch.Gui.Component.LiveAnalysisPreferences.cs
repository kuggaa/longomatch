
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class LiveAnalysisPreferences
	{
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.Table table1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label dirlabel;
		private global::Gtk.Button dirbutton;
		private global::Gtk.Label label1;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.LiveAnalysisPreferences
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.LiveAnalysisPreferences";
			// Container child LongoMatch.Gui.Component.LiveAnalysisPreferences.Gtk.Container+ContainerChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.dirlabel = new global::Gtk.Label ();
			this.dirlabel.Name = "dirlabel";
			this.dirlabel.LabelProp = "";
			this.dirlabel.Wrap = true;
			this.dirlabel.Ellipsize = ((global::Pango.EllipsizeMode)(1));
			this.dirlabel.MaxWidthChars = 20;
			this.hbox1.Add (this.dirlabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.dirlabel]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.dirbutton = new global::Gtk.Button ();
			this.dirbutton.CanFocus = true;
			this.dirbutton.Name = "dirbutton";
			this.dirbutton.UseStock = true;
			this.dirbutton.UseUnderline = true;
			this.dirbutton.Label = "gtk-open";
			this.hbox1.Add (this.dirbutton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.dirbutton]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Review plays in the same window");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Output directory");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Render new plays automatically\n(Requires a powerful CPU)");
			this.label4.UseMarkup = true;
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table1);
			this.scrolledwindow1.Add (w1);
			this.Add (this.scrolledwindow1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.dirbutton.Clicked += new global::System.EventHandler (this.OnDirbuttonClicked);
		}
	}
}