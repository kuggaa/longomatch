
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class TeamTemplateEditor
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Frame teamframe;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.VBox vbox5;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Frame shieldframe;
		private global::Gtk.Alignment shieldalignment;
		private global::Gtk.EventBox shieldeventbox;
		private global::Gtk.VBox shieldvbox;
		private global::Gtk.Image shieldimage;
		private global::Gtk.Label teamshieldlabel1;
		private global::Gtk.Label teamshieldlabel2;
		private global::Gtk.Table teamtable;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Entry tacticsentry;
		private global::Gtk.Button applybutton;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label nplayerslabel;
		private global::Gtk.Entry teamnameentry;
		private global::Gtk.DrawingArea drawingarea;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Frame playerframe;
		private global::Gtk.Alignment playerpropertyalignment;
		private global::Gtk.HBox playerpropertyhbox;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Frame playerimageframe;
		private global::Gtk.Alignment playerimagealignment;
		private global::Gtk.EventBox playereventbox;
		private global::Gtk.VBox playervbox;
		private global::Gtk.Image playerimage;
		private global::Gtk.Label playerimagelabel1;
		private global::Gtk.Label playerimagelabel2;
		private global::Gtk.Table table1;
		private global::LongoMatch.Gui.Component.DatePicker bdaydatepicker;
		private global::Gtk.SpinButton heightspinbutton;
		private global::Gtk.Label label11;
		private global::Gtk.Label label12;
		private global::Gtk.Label label3;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label8;
		private global::Gtk.Entry mailentry;
		private global::Gtk.Label maillabel;
		private global::Gtk.Entry nameentry;
		private global::Gtk.Entry nationalityentry;
		private global::Gtk.SpinButton numberspinbutton;
		private global::Gtk.Entry positionentry;
		private global::Gtk.SpinButton weightspinbutton;
		private global::Gtk.HButtonBox hbuttonbox2;
		private global::Gtk.Button savebutton;
		private global::Gtk.Button newplayerbutton;
		private global::Gtk.Button deletebutton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.TeamTemplateEditor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.TeamTemplateEditor";
			// Container child LongoMatch.Gui.Component.TeamTemplateEditor.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.teamframe = new global::Gtk.Frame ();
			this.teamframe.Name = "teamframe";
			this.teamframe.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child teamframe.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			this.GtkAlignment3.TopPadding = ((uint)(12));
			this.GtkAlignment3.RightPadding = ((uint)(12));
			this.GtkAlignment3.BottomPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 30;
			// Container child hbox2.Gtk.Box+BoxChild
			this.shieldframe = new global::Gtk.Frame ();
			this.shieldframe.Name = "shieldframe";
			this.shieldframe.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child shieldframe.Gtk.Container+ContainerChild
			this.shieldalignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.shieldalignment.Name = "shieldalignment";
			this.shieldalignment.LeftPadding = ((uint)(12));
			this.shieldalignment.TopPadding = ((uint)(12));
			this.shieldalignment.RightPadding = ((uint)(12));
			this.shieldalignment.BottomPadding = ((uint)(12));
			// Container child shieldalignment.Gtk.Container+ContainerChild
			this.shieldeventbox = new global::Gtk.EventBox ();
			this.shieldeventbox.Name = "shieldeventbox";
			// Container child shieldeventbox.Gtk.Container+ContainerChild
			this.shieldvbox = new global::Gtk.VBox ();
			this.shieldvbox.Name = "shieldvbox";
			this.shieldvbox.Spacing = 2;
			// Container child shieldvbox.Gtk.Box+BoxChild
			this.shieldimage = new global::Gtk.Image ();
			this.shieldimage.Name = "shieldimage";
			this.shieldvbox.Add (this.shieldimage);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.shieldvbox [this.shieldimage]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child shieldvbox.Gtk.Box+BoxChild
			this.teamshieldlabel1 = new global::Gtk.Label ();
			this.teamshieldlabel1.Name = "teamshieldlabel1";
			this.teamshieldlabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Team shield</span>");
			this.teamshieldlabel1.UseMarkup = true;
			this.shieldvbox.Add (this.teamshieldlabel1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.shieldvbox [this.teamshieldlabel1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child shieldvbox.Gtk.Box+BoxChild
			this.teamshieldlabel2 = new global::Gtk.Label ();
			this.teamshieldlabel2.Name = "teamshieldlabel2";
			this.teamshieldlabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"8\">click to change...</span>");
			this.teamshieldlabel2.UseMarkup = true;
			this.shieldvbox.Add (this.teamshieldlabel2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.shieldvbox [this.teamshieldlabel2]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.shieldeventbox.Add (this.shieldvbox);
			this.shieldalignment.Add (this.shieldeventbox);
			this.shieldframe.Add (this.shieldalignment);
			this.hbox2.Add (this.shieldframe);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.shieldframe]));
			w7.Position = 0;
			w7.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.teamtable = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.teamtable.WidthRequest = 300;
			this.teamtable.Name = "teamtable";
			this.teamtable.RowSpacing = ((uint)(6));
			this.teamtable.ColumnSpacing = ((uint)(6));
			// Container child teamtable.Gtk.Table+TableChild
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.Xalign = 1F;
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Team name</span>");
			this.GtkLabel4.UseMarkup = true;
			this.teamtable.Add (this.GtkLabel4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.teamtable [this.GtkLabel4]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child teamtable.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.tacticsentry = new global::Gtk.Entry ();
			this.tacticsentry.WidthRequest = 30;
			this.tacticsentry.CanFocus = true;
			this.tacticsentry.Name = "tacticsentry";
			this.tacticsentry.IsEditable = true;
			this.tacticsentry.InvisibleChar = '•';
			this.hbox5.Add (this.tacticsentry);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.tacticsentry]));
			w9.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.applybutton = new global::Gtk.Button ();
			this.applybutton.CanFocus = true;
			this.applybutton.Name = "applybutton";
			this.applybutton.UseUnderline = true;
			// Container child applybutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w10 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w11 = new global::Gtk.HBox ();
			w11.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w11.Add (w12);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w14 = new global::Gtk.Label ();
			w11.Add (w14);
			w10.Add (w11);
			this.applybutton.Add (w10);
			this.hbox5.Add (this.applybutton);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.applybutton]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.teamtable.Add (this.hbox5);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.teamtable [this.hbox5]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child teamtable.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Number of players</span>");
			this.label1.UseMarkup = true;
			this.teamtable.Add (this.label1);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.teamtable [this.label1]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			// Container child teamtable.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Tactics</span>");
			this.label2.UseMarkup = true;
			this.teamtable.Add (this.label2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.teamtable [this.label2]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child teamtable.Gtk.Table+TableChild
			this.nplayerslabel = new global::Gtk.Label ();
			this.nplayerslabel.Name = "nplayerslabel";
			this.nplayerslabel.Xalign = 0F;
			this.teamtable.Add (this.nplayerslabel);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.teamtable [this.nplayerslabel]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child teamtable.Gtk.Table+TableChild
			this.teamnameentry = new global::Gtk.Entry ();
			this.teamnameentry.WidthRequest = 100;
			this.teamnameentry.CanFocus = true;
			this.teamnameentry.Name = "teamnameentry";
			this.teamnameentry.IsEditable = true;
			this.teamnameentry.InvisibleChar = '•';
			this.teamtable.Add (this.teamnameentry);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.teamtable [this.teamnameentry]));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox2.Add (this.teamtable);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.teamtable]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox5.Add (this.hbox2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox2]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.drawingarea = new global::Gtk.DrawingArea ();
			this.drawingarea.Name = "drawingarea";
			this.vbox5.Add (this.drawingarea);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.drawingarea]));
			w26.Position = 1;
			this.GtkAlignment3.Add (this.vbox5);
			this.teamframe.Add (this.GtkAlignment3);
			this.hbox4.Add (this.teamframe);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.teamframe]));
			w29.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0F, 1F, 0F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.playerframe = new global::Gtk.Frame ();
			this.playerframe.Sensitive = false;
			this.playerframe.Name = "playerframe";
			this.playerframe.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child playerframe.Gtk.Container+ContainerChild
			this.playerpropertyalignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.playerpropertyalignment.Name = "playerpropertyalignment";
			this.playerpropertyalignment.LeftPadding = ((uint)(12));
			this.playerpropertyalignment.TopPadding = ((uint)(12));
			this.playerpropertyalignment.RightPadding = ((uint)(12));
			this.playerpropertyalignment.BottomPadding = ((uint)(12));
			// Container child playerpropertyalignment.Gtk.Container+ContainerChild
			this.playerpropertyhbox = new global::Gtk.HBox ();
			this.playerpropertyhbox.Name = "playerpropertyhbox";
			this.playerpropertyhbox.Spacing = 6;
			// Container child playerpropertyhbox.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0F, 0F, 0F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.playerimageframe = new global::Gtk.Frame ();
			this.playerimageframe.Name = "playerimageframe";
			this.playerimageframe.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child playerimageframe.Gtk.Container+ContainerChild
			this.playerimagealignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.playerimagealignment.Name = "playerimagealignment";
			this.playerimagealignment.LeftPadding = ((uint)(12));
			this.playerimagealignment.TopPadding = ((uint)(12));
			this.playerimagealignment.RightPadding = ((uint)(12));
			this.playerimagealignment.BottomPadding = ((uint)(12));
			// Container child playerimagealignment.Gtk.Container+ContainerChild
			this.playereventbox = new global::Gtk.EventBox ();
			this.playereventbox.Name = "playereventbox";
			// Container child playereventbox.Gtk.Container+ContainerChild
			this.playervbox = new global::Gtk.VBox ();
			this.playervbox.Name = "playervbox";
			this.playervbox.Spacing = 2;
			// Container child playervbox.Gtk.Box+BoxChild
			this.playerimage = new global::Gtk.Image ();
			this.playerimage.Name = "playerimage";
			this.playervbox.Add (this.playerimage);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.playervbox [this.playerimage]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child playervbox.Gtk.Box+BoxChild
			this.playerimagelabel1 = new global::Gtk.Label ();
			this.playerimagelabel1.Name = "playerimagelabel1";
			this.playerimagelabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Player picture</span>");
			this.playerimagelabel1.UseMarkup = true;
			this.playervbox.Add (this.playerimagelabel1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.playervbox [this.playerimagelabel1]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child playervbox.Gtk.Box+BoxChild
			this.playerimagelabel2 = new global::Gtk.Label ();
			this.playerimagelabel2.Name = "playerimagelabel2";
			this.playerimagelabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"8\">click to change...</span>");
			this.playerimagelabel2.UseMarkup = true;
			this.playervbox.Add (this.playerimagelabel2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.playervbox [this.playerimagelabel2]));
			w32.Position = 2;
			w32.Expand = false;
			w32.Fill = false;
			this.playereventbox.Add (this.playervbox);
			this.playerimagealignment.Add (this.playereventbox);
			this.playerimageframe.Add (this.playerimagealignment);
			this.alignment1.Add (this.playerimageframe);
			this.playerpropertyhbox.Add (this.alignment1);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.playerpropertyhbox [this.alignment1]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child playerpropertyhbox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(8)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.bdaydatepicker = new global::LongoMatch.Gui.Component.DatePicker ();
			this.bdaydatepicker.Events = ((global::Gdk.EventMask)(256));
			this.bdaydatepicker.Name = "bdaydatepicker";
			this.bdaydatepicker.Date = new global::System.DateTime (0);
			this.table1.Add (this.bdaydatepicker);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table1 [this.bdaydatepicker]));
			w38.TopAttach = ((uint)(6));
			w38.BottomAttach = ((uint)(7));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.heightspinbutton = new global::Gtk.SpinButton (0, 100, 1);
			this.heightspinbutton.CanFocus = true;
			this.heightspinbutton.Name = "heightspinbutton";
			this.heightspinbutton.Adjustment.PageIncrement = 10;
			this.heightspinbutton.ClimbRate = 1;
			this.heightspinbutton.Digits = ((uint)(2));
			this.heightspinbutton.Numeric = true;
			this.heightspinbutton.Value = 18;
			this.table1.Add (this.heightspinbutton);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table1 [this.heightspinbutton]));
			w39.TopAttach = ((uint)(4));
			w39.BottomAttach = ((uint)(5));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Position</span>");
			this.label11.UseMarkup = true;
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w40.TopAttach = ((uint)(2));
			w40.BottomAttach = ((uint)(3));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 1F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Name</span>");
			this.label12.UseMarkup = true;
			this.table1.Add (this.label12);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table1 [this.label12]));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Number</span>");
			this.label3.UseMarkup = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w42.TopAttach = ((uint)(3));
			w42.BottomAttach = ((uint)(4));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Height</span>");
			this.label5.UseMarkup = true;
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w43.TopAttach = ((uint)(4));
			w43.BottomAttach = ((uint)(5));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Weight</span>");
			this.label6.UseMarkup = true;
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w44.TopAttach = ((uint)(5));
			w44.BottomAttach = ((uint)(6));
			w44.XOptions = ((global::Gtk.AttachOptions)(4));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Birth Date</span>");
			this.label7.UseMarkup = true;
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table1 [this.label7]));
			w45.TopAttach = ((uint)(6));
			w45.BottomAttach = ((uint)(7));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">Nationality</span>");
			this.label8.UseMarkup = true;
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
			w46.TopAttach = ((uint)(1));
			w46.BottomAttach = ((uint)(2));
			w46.XOptions = ((global::Gtk.AttachOptions)(4));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.mailentry = new global::Gtk.Entry ();
			this.mailentry.CanFocus = true;
			this.mailentry.Name = "mailentry";
			this.mailentry.IsEditable = true;
			this.mailentry.InvisibleChar = '•';
			this.table1.Add (this.mailentry);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table1 [this.mailentry]));
			w47.TopAttach = ((uint)(7));
			w47.BottomAttach = ((uint)(8));
			w47.LeftAttach = ((uint)(1));
			w47.RightAttach = ((uint)(2));
			w47.XOptions = ((global::Gtk.AttachOptions)(4));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.maillabel = new global::Gtk.Label ();
			this.maillabel.Name = "maillabel";
			this.maillabel.Xalign = 1F;
			this.maillabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc=\"10\">E-mail</span>");
			this.maillabel.UseMarkup = true;
			this.table1.Add (this.maillabel);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table1 [this.maillabel]));
			w48.TopAttach = ((uint)(7));
			w48.BottomAttach = ((uint)(8));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nameentry = new global::Gtk.Entry ();
			this.nameentry.CanFocus = true;
			this.nameentry.Name = "nameentry";
			this.nameentry.IsEditable = true;
			this.nameentry.InvisibleChar = '●';
			this.table1.Add (this.nameentry);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table1 [this.nameentry]));
			w49.LeftAttach = ((uint)(1));
			w49.RightAttach = ((uint)(2));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nationalityentry = new global::Gtk.Entry ();
			this.nationalityentry.CanFocus = true;
			this.nationalityentry.Name = "nationalityentry";
			this.nationalityentry.IsEditable = true;
			this.nationalityentry.InvisibleChar = '●';
			this.table1.Add (this.nationalityentry);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.table1 [this.nationalityentry]));
			w50.TopAttach = ((uint)(1));
			w50.BottomAttach = ((uint)(2));
			w50.LeftAttach = ((uint)(1));
			w50.RightAttach = ((uint)(2));
			w50.XOptions = ((global::Gtk.AttachOptions)(4));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.numberspinbutton = new global::Gtk.SpinButton (0, 100, 1);
			this.numberspinbutton.CanFocus = true;
			this.numberspinbutton.Name = "numberspinbutton";
			this.numberspinbutton.Adjustment.PageIncrement = 10;
			this.numberspinbutton.ClimbRate = 1;
			this.numberspinbutton.Numeric = true;
			this.table1.Add (this.numberspinbutton);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table1 [this.numberspinbutton]));
			w51.TopAttach = ((uint)(3));
			w51.BottomAttach = ((uint)(4));
			w51.LeftAttach = ((uint)(1));
			w51.RightAttach = ((uint)(2));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.positionentry = new global::Gtk.Entry ();
			this.positionentry.CanFocus = true;
			this.positionentry.Name = "positionentry";
			this.positionentry.IsEditable = true;
			this.positionentry.InvisibleChar = '●';
			this.table1.Add (this.positionentry);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table1 [this.positionentry]));
			w52.TopAttach = ((uint)(2));
			w52.BottomAttach = ((uint)(3));
			w52.LeftAttach = ((uint)(1));
			w52.RightAttach = ((uint)(2));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.weightspinbutton = new global::Gtk.SpinButton (0, 1000, 1);
			this.weightspinbutton.CanFocus = true;
			this.weightspinbutton.Name = "weightspinbutton";
			this.weightspinbutton.Adjustment.PageIncrement = 10;
			this.weightspinbutton.ClimbRate = 1;
			this.weightspinbutton.Numeric = true;
			this.weightspinbutton.Value = 80;
			this.table1.Add (this.weightspinbutton);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table1 [this.weightspinbutton]));
			w53.TopAttach = ((uint)(5));
			w53.BottomAttach = ((uint)(6));
			w53.LeftAttach = ((uint)(1));
			w53.RightAttach = ((uint)(2));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			this.playerpropertyhbox.Add (this.table1);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.playerpropertyhbox [this.table1]));
			w54.Position = 1;
			w54.Expand = false;
			w54.Fill = false;
			this.playerpropertyalignment.Add (this.playerpropertyhbox);
			this.playerframe.Add (this.playerpropertyalignment);
			this.alignment2.Add (this.playerframe);
			this.hbox4.Add (this.alignment2);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.alignment2]));
			w58.Position = 1;
			w58.Expand = false;
			w58.Fill = false;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
			w59.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.savebutton = new global::Gtk.Button ();
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			this.savebutton.UseUnderline = true;
			// Container child savebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w60 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w61 = new global::Gtk.HBox ();
			w61.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w62 = new global::Gtk.Image ();
			w62.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Dialog);
			w61.Add (w62);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w64 = new global::Gtk.Label ();
			w64.LabelProp = global::Mono.Unix.Catalog.GetString ("Save template");
			w64.UseUnderline = true;
			w61.Add (w64);
			w60.Add (w61);
			this.savebutton.Add (w60);
			this.hbuttonbox2.Add (this.savebutton);
			global::Gtk.ButtonBox.ButtonBoxChild w68 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.savebutton]));
			w68.Expand = false;
			w68.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.newplayerbutton = new global::Gtk.Button ();
			this.newplayerbutton.CanFocus = true;
			this.newplayerbutton.Name = "newplayerbutton";
			this.newplayerbutton.UseUnderline = true;
			// Container child newplayerbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w69 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w70 = new global::Gtk.HBox ();
			w70.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w71 = new global::Gtk.Image ();
			w71.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-new", global::Gtk.IconSize.Dialog);
			w70.Add (w71);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w73 = new global::Gtk.Label ();
			w73.LabelProp = global::Mono.Unix.Catalog.GetString ("New player");
			w73.UseUnderline = true;
			w70.Add (w73);
			w69.Add (w70);
			this.newplayerbutton.Add (w69);
			this.hbuttonbox2.Add (this.newplayerbutton);
			global::Gtk.ButtonBox.ButtonBoxChild w77 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.newplayerbutton]));
			w77.Position = 1;
			w77.Expand = false;
			w77.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.deletebutton = new global::Gtk.Button ();
			this.deletebutton.CanFocus = true;
			this.deletebutton.Name = "deletebutton";
			this.deletebutton.UseUnderline = true;
			// Container child deletebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w78 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w79 = new global::Gtk.HBox ();
			w79.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w80 = new global::Gtk.Image ();
			w80.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Dialog);
			w79.Add (w80);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w82 = new global::Gtk.Label ();
			w82.LabelProp = global::Mono.Unix.Catalog.GetString ("Delete player");
			w82.UseUnderline = true;
			w79.Add (w82);
			w78.Add (w79);
			this.deletebutton.Add (w78);
			this.hbuttonbox2.Add (this.deletebutton);
			global::Gtk.ButtonBox.ButtonBoxChild w86 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.deletebutton]));
			w86.Position = 2;
			w86.Expand = false;
			w86.Fill = false;
			this.vbox3.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w87 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbuttonbox2]));
			w87.Position = 1;
			w87.Expand = false;
			w87.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
