
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class CategoryProperties
	{
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Table maintable;
		
		private global::Gtk.ColorButton colorbutton1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Entry nameentry;
		
		private global::Gtk.Table texttable;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.Label hotKeyLabel;
		
		private global::Gtk.Button changebuton;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.ColorButton textcolorbutton;
		
		private global::Gtk.Label textcolorlabel;
		
		private global::Gtk.Table timetable;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.SpinButton lagtimebutton;
		
		private global::Gtk.SpinButton leadtimebutton;
		
		private global::Gtk.Label taglabel;
		
		private global::Gtk.ComboBox tagmodecombobox;
		
		private global::Gtk.Table postable;
		
		private global::Gtk.ComboBox fieldcombobox;
		
		private global::Gtk.ComboBox goalcombobox;
		
		private global::Gtk.ComboBox hfieldcombobox;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Label label12;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.ComboBox sortmethodcombobox;
		
		private global::Gtk.Table cattable;
		
		private global::Gtk.Label label15;
		
		private global::Gtk.Label showtagslabel;
		
		private global::Gtk.CheckButton tagscheckbutton;
		
		private global::Gtk.SpinButton tprbutton;
		
		private global::Gtk.Table cardtable;
		
		private global::Gtk.Label label16;
		
		private global::Gtk.ComboBox shapecombobox;
		
		private global::Gtk.Table scoretable;
		
		private global::Gtk.Label label17;
		
		private global::Gtk.SpinButton pointsbutton;
		
		private global::Gtk.Table timertable;
		
		private global::Gtk.Label label18;
		
		private global::Gtk.ComboBox teamcombobox;
		
		private global::Gtk.Table tagtable;
		
		private global::Gtk.Entry groupentry;
		
		private global::Gtk.Label label19;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.CategoryProperties
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.CategoryProperties";
			// Container child LongoMatch.Gui.Component.CategoryProperties.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.maintable = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.maintable.Name = "maintable";
			this.maintable.RowSpacing = ((uint)(6));
			this.maintable.ColumnSpacing = ((uint)(6));
			// Container child maintable.Gtk.Table+TableChild
			this.colorbutton1 = new global::Gtk.ColorButton ();
			this.colorbutton1.CanFocus = true;
			this.colorbutton1.Events = ((global::Gdk.EventMask)(784));
			this.colorbutton1.Name = "colorbutton1";
			this.maintable.Add (this.colorbutton1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.maintable [this.colorbutton1]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child maintable.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.label1.UseMarkup = true;
			this.maintable.Add (this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.maintable [this.label1]));
			w2.XOptions = ((global::Gtk.AttachOptions)(0));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child maintable.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Color");
			this.label4.UseMarkup = true;
			this.maintable.Add (this.label4);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.maintable [this.label4]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(0));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child maintable.Gtk.Table+TableChild
			this.nameentry = new global::Gtk.Entry ();
			this.nameentry.WidthRequest = 76;
			this.nameentry.CanFocus = true;
			this.nameentry.Name = "nameentry";
			this.nameentry.IsEditable = true;
			this.nameentry.InvisibleChar = '●';
			this.maintable.Add (this.nameentry);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.maintable [this.nameentry]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.maintable);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.maintable]));
			w5.Position = 0;
			w5.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.texttable = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.texttable.Name = "texttable";
			this.texttable.RowSpacing = ((uint)(6));
			this.texttable.ColumnSpacing = ((uint)(6));
			// Container child texttable.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hotKeyLabel = new global::Gtk.Label ();
			this.hotKeyLabel.Name = "hotKeyLabel";
			this.hotKeyLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("none");
			this.hbox5.Add (this.hotKeyLabel);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.hotKeyLabel]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.changebuton = new global::Gtk.Button ();
			this.changebuton.CanFocus = true;
			this.changebuton.Name = "changebuton";
			this.changebuton.UseUnderline = true;
			this.changebuton.Label = global::Mono.Unix.Catalog.GetString ("Change");
			this.hbox5.Add (this.changebuton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.changebuton]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.texttable.Add (this.hbox5);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.texttable [this.hbox5]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child texttable.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("HotKey");
			this.label6.UseMarkup = true;
			this.texttable.Add (this.label6);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.texttable [this.label6]));
			w9.XOptions = ((global::Gtk.AttachOptions)(0));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child texttable.Gtk.Table+TableChild
			this.textcolorbutton = new global::Gtk.ColorButton ();
			this.textcolorbutton.CanFocus = true;
			this.textcolorbutton.Events = ((global::Gdk.EventMask)(784));
			this.textcolorbutton.Name = "textcolorbutton";
			this.texttable.Add (this.textcolorbutton);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.texttable [this.textcolorbutton]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child texttable.Gtk.Table+TableChild
			this.textcolorlabel = new global::Gtk.Label ();
			this.textcolorlabel.Name = "textcolorlabel";
			this.textcolorlabel.Xalign = 1F;
			this.textcolorlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Text color");
			this.textcolorlabel.UseMarkup = true;
			this.texttable.Add (this.textcolorlabel);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.texttable [this.textcolorlabel]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(0));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.texttable);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.texttable]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.timetable = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.timetable.Name = "timetable";
			this.timetable.RowSpacing = ((uint)(6));
			this.timetable.ColumnSpacing = ((uint)(6));
			// Container child timetable.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Lead time (s)");
			this.label7.UseMarkup = true;
			this.timetable.Add (this.label7);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.timetable [this.label7]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(0));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child timetable.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Lag time (s)");
			this.label8.UseMarkup = true;
			this.timetable.Add (this.label8);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.timetable [this.label8]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(0));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child timetable.Gtk.Table+TableChild
			this.lagtimebutton = new global::Gtk.SpinButton (0, 1000, 1);
			this.lagtimebutton.CanFocus = true;
			this.lagtimebutton.Name = "lagtimebutton";
			this.lagtimebutton.Adjustment.PageIncrement = 1;
			this.lagtimebutton.ClimbRate = 1;
			this.lagtimebutton.Numeric = true;
			this.timetable.Add (this.lagtimebutton);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.timetable [this.lagtimebutton]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child timetable.Gtk.Table+TableChild
			this.leadtimebutton = new global::Gtk.SpinButton (0, 1000, 1);
			this.leadtimebutton.CanFocus = true;
			this.leadtimebutton.Name = "leadtimebutton";
			this.leadtimebutton.Adjustment.PageIncrement = 1;
			this.leadtimebutton.ClimbRate = 1;
			this.leadtimebutton.Numeric = true;
			this.timetable.Add (this.leadtimebutton);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.timetable [this.leadtimebutton]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child timetable.Gtk.Table+TableChild
			this.taglabel = new global::Gtk.Label ();
			this.taglabel.Name = "taglabel";
			this.taglabel.Xalign = 1F;
			this.taglabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Tag mode");
			this.taglabel.UseMarkup = true;
			this.timetable.Add (this.taglabel);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.timetable [this.taglabel]));
			w17.XOptions = ((global::Gtk.AttachOptions)(0));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child timetable.Gtk.Table+TableChild
			this.tagmodecombobox = global::Gtk.ComboBox.NewText ();
			this.tagmodecombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Automatic"));
			this.tagmodecombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Manual"));
			this.tagmodecombobox.Name = "tagmodecombobox";
			this.tagmodecombobox.Active = 0;
			this.timetable.Add (this.tagmodecombobox);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.timetable [this.tagmodecombobox]));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.timetable);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.timetable]));
			w19.Position = 2;
			w19.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.postable = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.postable.Name = "postable";
			this.postable.RowSpacing = ((uint)(6));
			this.postable.ColumnSpacing = ((uint)(6));
			// Container child postable.Gtk.Table+TableChild
			this.fieldcombobox = global::Gtk.ComboBox.NewText ();
			this.fieldcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Not tagged"));
			this.fieldcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Tag as point"));
			this.fieldcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Tag as trajectory"));
			this.fieldcombobox.Name = "fieldcombobox";
			this.fieldcombobox.Active = 0;
			this.postable.Add (this.fieldcombobox);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.postable [this.fieldcombobox]));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child postable.Gtk.Table+TableChild
			this.goalcombobox = global::Gtk.ComboBox.NewText ();
			this.goalcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Not tagged"));
			this.goalcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Tag as point"));
			this.goalcombobox.Name = "goalcombobox";
			this.goalcombobox.Active = 0;
			this.postable.Add (this.goalcombobox);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.postable [this.goalcombobox]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child postable.Gtk.Table+TableChild
			this.hfieldcombobox = global::Gtk.ComboBox.NewText ();
			this.hfieldcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Not tagged"));
			this.hfieldcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Tag as point"));
			this.hfieldcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Tag as trajectory"));
			this.hfieldcombobox.Name = "hfieldcombobox";
			this.hfieldcombobox.Active = 0;
			this.postable.Add (this.hfieldcombobox);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.postable [this.hfieldcombobox]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child postable.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Field position");
			this.label10.UseMarkup = true;
			this.postable.Add (this.label10);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.postable [this.label10]));
			w23.XOptions = ((global::Gtk.AttachOptions)(0));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child postable.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Half field position");
			this.label11.UseMarkup = true;
			this.postable.Add (this.label11);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.postable [this.label11]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(0));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child postable.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 1F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Goal position");
			this.label12.UseMarkup = true;
			this.postable.Add (this.label12);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.postable [this.label12]));
			w25.TopAttach = ((uint)(2));
			w25.BottomAttach = ((uint)(3));
			w25.XOptions = ((global::Gtk.AttachOptions)(0));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child postable.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Sort Method");
			this.label9.UseMarkup = true;
			this.postable.Add (this.label9);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.postable [this.label9]));
			w26.TopAttach = ((uint)(3));
			w26.BottomAttach = ((uint)(4));
			w26.XOptions = ((global::Gtk.AttachOptions)(0));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child postable.Gtk.Table+TableChild
			this.sortmethodcombobox = global::Gtk.ComboBox.NewText ();
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by name"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by start time"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by stop time"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by duration"));
			this.sortmethodcombobox.Name = "sortmethodcombobox";
			this.sortmethodcombobox.Active = 0;
			this.postable.Add (this.sortmethodcombobox);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.postable [this.sortmethodcombobox]));
			w27.TopAttach = ((uint)(3));
			w27.BottomAttach = ((uint)(4));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.postable);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.postable]));
			w28.Position = 3;
			w28.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.cattable = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.cattable.Name = "cattable";
			this.cattable.RowSpacing = ((uint)(6));
			this.cattable.ColumnSpacing = ((uint)(6));
			// Container child cattable.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.Xalign = 1F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Tags per row");
			this.label15.UseMarkup = true;
			this.cattable.Add (this.label15);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.cattable [this.label15]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(0));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child cattable.Gtk.Table+TableChild
			this.showtagslabel = new global::Gtk.Label ();
			this.showtagslabel.Name = "showtagslabel";
			this.showtagslabel.Xalign = 1F;
			this.showtagslabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Show tags");
			this.showtagslabel.UseMarkup = true;
			this.cattable.Add (this.showtagslabel);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.cattable [this.showtagslabel]));
			w30.XOptions = ((global::Gtk.AttachOptions)(0));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child cattable.Gtk.Table+TableChild
			this.tagscheckbutton = new global::Gtk.CheckButton ();
			this.tagscheckbutton.CanFocus = true;
			this.tagscheckbutton.Name = "tagscheckbutton";
			this.tagscheckbutton.Label = "";
			this.tagscheckbutton.Active = true;
			this.tagscheckbutton.DrawIndicator = true;
			this.cattable.Add (this.tagscheckbutton);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.cattable [this.tagscheckbutton]));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child cattable.Gtk.Table+TableChild
			this.tprbutton = new global::Gtk.SpinButton (1, 10, 1);
			this.tprbutton.CanFocus = true;
			this.tprbutton.Name = "tprbutton";
			this.tprbutton.Adjustment.PageIncrement = 1;
			this.tprbutton.ClimbRate = 1;
			this.tprbutton.Numeric = true;
			this.tprbutton.Value = 2;
			this.cattable.Add (this.tprbutton);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.cattable [this.tprbutton]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.cattable);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.cattable]));
			w33.Position = 4;
			w33.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.cardtable = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.cardtable.Name = "cardtable";
			this.cardtable.RowSpacing = ((uint)(6));
			this.cardtable.ColumnSpacing = ((uint)(6));
			// Container child cardtable.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.Xalign = 1F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("Shape");
			this.label16.UseMarkup = true;
			this.cardtable.Add (this.label16);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.cardtable [this.label16]));
			w34.XOptions = ((global::Gtk.AttachOptions)(0));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child cardtable.Gtk.Table+TableChild
			this.shapecombobox = global::Gtk.ComboBox.NewText ();
			this.shapecombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Rectangle"));
			this.shapecombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Triangle"));
			this.shapecombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Circle"));
			this.shapecombobox.Name = "shapecombobox";
			this.shapecombobox.Active = 0;
			this.cardtable.Add (this.shapecombobox);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.cardtable [this.shapecombobox]));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.cardtable);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.cardtable]));
			w36.Position = 5;
			w36.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.scoretable = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.scoretable.Name = "scoretable";
			this.scoretable.RowSpacing = ((uint)(6));
			this.scoretable.ColumnSpacing = ((uint)(6));
			// Container child scoretable.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.Xalign = 1F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("Points");
			this.label17.UseMarkup = true;
			this.scoretable.Add (this.label17);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.scoretable [this.label17]));
			w37.XOptions = ((global::Gtk.AttachOptions)(0));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child scoretable.Gtk.Table+TableChild
			this.pointsbutton = new global::Gtk.SpinButton (0, 1000, 1);
			this.pointsbutton.CanFocus = true;
			this.pointsbutton.Name = "pointsbutton";
			this.pointsbutton.Adjustment.PageIncrement = 1;
			this.pointsbutton.ClimbRate = 1;
			this.pointsbutton.Numeric = true;
			this.scoretable.Add (this.pointsbutton);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.scoretable [this.pointsbutton]));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.scoretable);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.scoretable]));
			w39.Position = 6;
			w39.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.timertable = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.timertable.Name = "timertable";
			this.timertable.RowSpacing = ((uint)(6));
			this.timertable.ColumnSpacing = ((uint)(6));
			// Container child timertable.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.Xalign = 1F;
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("Team");
			this.label18.UseMarkup = true;
			this.timertable.Add (this.label18);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.timertable [this.label18]));
			w40.XOptions = ((global::Gtk.AttachOptions)(0));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child timertable.Gtk.Table+TableChild
			this.teamcombobox = global::Gtk.ComboBox.NewText ();
			this.teamcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("None"));
			this.teamcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Home"));
			this.teamcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Away"));
			this.teamcombobox.Name = "teamcombobox";
			this.teamcombobox.Active = 0;
			this.timertable.Add (this.teamcombobox);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.timertable [this.teamcombobox]));
			w41.LeftAttach = ((uint)(1));
			w41.RightAttach = ((uint)(2));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.timertable);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.timertable]));
			w42.Position = 7;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.tagtable = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.tagtable.Name = "tagtable";
			this.tagtable.RowSpacing = ((uint)(6));
			this.tagtable.ColumnSpacing = ((uint)(6));
			// Container child tagtable.Gtk.Table+TableChild
			this.groupentry = new global::Gtk.Entry ();
			this.groupentry.CanFocus = true;
			this.groupentry.Name = "groupentry";
			this.groupentry.IsEditable = true;
			this.groupentry.InvisibleChar = '•';
			this.tagtable.Add (this.groupentry);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.tagtable [this.groupentry]));
			w43.LeftAttach = ((uint)(1));
			w43.RightAttach = ((uint)(2));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tagtable.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.Xalign = 1F;
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Group");
			this.label19.UseMarkup = true;
			this.tagtable.Add (this.label19);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.tagtable [this.label19]));
			w44.XOptions = ((global::Gtk.AttachOptions)(0));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.tagtable);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.tagtable]));
			w45.Position = 8;
			w45.Expand = false;
			w45.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.cattable.Hide ();
			this.cardtable.Hide ();
			this.scoretable.Hide ();
			this.timertable.Hide ();
			this.tagtable.Hide ();
			this.Show ();
		}
	}
}
