
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Popup
{
	public partial class CalendarPopup
	{
		private global::Gtk.Calendar calendar1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Popup.CalendarPopup
			this.Name = "LongoMatch.Gui.Popup.CalendarPopup";
			this.Title = "";
			this.WindowPosition = ((global::Gtk.WindowPosition)(2));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			this.Decorated = false;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Container child LongoMatch.Gui.Popup.CalendarPopup.Gtk.Container+ContainerChild
			this.calendar1 = new global::Gtk.Calendar ();
			this.calendar1.CanFocus = true;
			this.calendar1.Name = "calendar1";
			this.calendar1.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(3));
			this.Add (this.calendar1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 281;
			this.DefaultHeight = 214;
			this.Show ();
			this.FocusOutEvent += new global::Gtk.FocusOutEventHandler (this.OnFocusOutEvent);
			this.calendar1.DaySelectedDoubleClick += new global::System.EventHandler (this.OnCalendar1DaySelectedDoubleClick);
		}
	}
}