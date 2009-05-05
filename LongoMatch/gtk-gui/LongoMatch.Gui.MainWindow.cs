// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui {
    
    
    public partial class MainWindow {
        
        private Gtk.UIManager UIManager;
        
        private Gtk.Action FileAction;
        
        private Gtk.Action NewPojectAction;
        
        private Gtk.Action OpenProjectAction;
        
        private Gtk.Action QuitAction;
        
        private Gtk.Action CloseProjectAction;
        
        private Gtk.Action ToolsAction;
        
        private Gtk.Action ProjectsManagerAction;
        
        private Gtk.Action TemplatesManagerAction;
        
        private Gtk.Action ViewAction;
        
        private Gtk.ToggleAction FullScreenAction;
        
        private Gtk.ToggleAction PlaylistAction;
        
        private Gtk.RadioAction CaptureModeAction;
        
        private Gtk.RadioAction AnalyzeModeAction;
        
        private Gtk.Action SaveProjectAction;
        
        private Gtk.Action HelpAction;
        
        private Gtk.Action AboutAction;
        
        private Gtk.Action ExportProjectToCSVFileAction;
        
        private Gtk.VBox vbox1;
        
        private Gtk.VBox menubox;
        
        private Gtk.MenuBar menubar1;
        
        private Gtk.HPaned hpaned;
        
        private Gtk.VBox leftbox;
        
        private LongoMatch.Gui.Component.TreeWidget treewidget1;
        
        private Gtk.HPaned hpaned1;
        
        private Gtk.VBox vbox5;
        
        private LongoMatch.Gui.PlayerBin playerbin1;
        
        private LongoMatch.Gui.Component.TimeLineWidget timelinewidget1;
        
        private LongoMatch.Gui.Component.ButtonsWidget buttonswidget1;
        
        private Gtk.VBox rightvbox;
        
        private LongoMatch.Gui.Component.NotesWidget noteswidget1;
        
        private LongoMatch.Gui.Component.PlayListWidget playlistwidget2;
        
        private Gtk.Statusbar statusbar1;
        
        private Gtk.ProgressBar videoprogressbar;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.MainWindow
            this.UIManager = new Gtk.UIManager();
            Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
            this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("_File"), null, null);
            this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("_File");
            w1.Add(this.FileAction, null);
            this.NewPojectAction = new Gtk.Action("NewPojectAction", Mono.Unix.Catalog.GetString("_New Poject"), null, "gtk-new");
            this.NewPojectAction.ShortLabel = Mono.Unix.Catalog.GetString("_New Poyect");
            w1.Add(this.NewPojectAction, null);
            this.OpenProjectAction = new Gtk.Action("OpenProjectAction", Mono.Unix.Catalog.GetString("_Open Project"), null, "gtk-open");
            this.OpenProjectAction.ShortLabel = Mono.Unix.Catalog.GetString("_Open Proyect");
            w1.Add(this.OpenProjectAction, null);
            this.QuitAction = new Gtk.Action("QuitAction", Mono.Unix.Catalog.GetString("_Quit"), null, "gtk-quit");
            this.QuitAction.ShortLabel = Mono.Unix.Catalog.GetString("_Quit");
            w1.Add(this.QuitAction, null);
            this.CloseProjectAction = new Gtk.Action("CloseProjectAction", Mono.Unix.Catalog.GetString("_Close Project"), null, "gtk-close");
            this.CloseProjectAction.Sensitive = false;
            this.CloseProjectAction.ShortLabel = Mono.Unix.Catalog.GetString("_Close Proyect");
            w1.Add(this.CloseProjectAction, null);
            this.ToolsAction = new Gtk.Action("ToolsAction", Mono.Unix.Catalog.GetString("_Tools"), null, null);
            this.ToolsAction.ShortLabel = Mono.Unix.Catalog.GetString("_Tools");
            w1.Add(this.ToolsAction, null);
            this.ProjectsManagerAction = new Gtk.Action("ProjectsManagerAction", Mono.Unix.Catalog.GetString("Projects Manager"), null, null);
            this.ProjectsManagerAction.ShortLabel = Mono.Unix.Catalog.GetString("Database Manager");
            w1.Add(this.ProjectsManagerAction, null);
            this.TemplatesManagerAction = new Gtk.Action("TemplatesManagerAction", Mono.Unix.Catalog.GetString("Templates Manager"), null, null);
            this.TemplatesManagerAction.ShortLabel = Mono.Unix.Catalog.GetString("Templates Manager");
            w1.Add(this.TemplatesManagerAction, null);
            this.ViewAction = new Gtk.Action("ViewAction", Mono.Unix.Catalog.GetString("_View"), null, null);
            this.ViewAction.ShortLabel = Mono.Unix.Catalog.GetString("_View");
            w1.Add(this.ViewAction, null);
            this.FullScreenAction = new Gtk.ToggleAction("FullScreenAction", Mono.Unix.Catalog.GetString("Full Screen"), null, "gtk-fullscreen");
            this.FullScreenAction.ShortLabel = Mono.Unix.Catalog.GetString("Full Screen");
            w1.Add(this.FullScreenAction, null);
            this.PlaylistAction = new Gtk.ToggleAction("PlaylistAction", Mono.Unix.Catalog.GetString("Playlist"), null, null);
            this.PlaylistAction.ShortLabel = Mono.Unix.Catalog.GetString("Playlist");
            w1.Add(this.PlaylistAction, null);
            this.CaptureModeAction = new Gtk.RadioAction("CaptureModeAction", Mono.Unix.Catalog.GetString("Capture Mode"), null, null, 0);
            this.CaptureModeAction.Group = new GLib.SList(System.IntPtr.Zero);
            this.CaptureModeAction.Sensitive = false;
            this.CaptureModeAction.ShortLabel = Mono.Unix.Catalog.GetString("Capture Mode");
            w1.Add(this.CaptureModeAction, null);
            this.AnalyzeModeAction = new Gtk.RadioAction("AnalyzeModeAction", Mono.Unix.Catalog.GetString("Analyze Mode"), null, null, 0);
            this.AnalyzeModeAction.Group = this.CaptureModeAction.Group;
            this.AnalyzeModeAction.Sensitive = false;
            this.AnalyzeModeAction.ShortLabel = Mono.Unix.Catalog.GetString("Analyze Mode");
            w1.Add(this.AnalyzeModeAction, null);
            this.SaveProjectAction = new Gtk.Action("SaveProjectAction", Mono.Unix.Catalog.GetString("_Save Project"), null, "gtk-save");
            this.SaveProjectAction.Sensitive = false;
            this.SaveProjectAction.ShortLabel = Mono.Unix.Catalog.GetString("_Save Project");
            w1.Add(this.SaveProjectAction, null);
            this.HelpAction = new Gtk.Action("HelpAction", Mono.Unix.Catalog.GetString("_Help"), null, null);
            this.HelpAction.ShortLabel = Mono.Unix.Catalog.GetString("_Help");
            w1.Add(this.HelpAction, null);
            this.AboutAction = new Gtk.Action("AboutAction", Mono.Unix.Catalog.GetString("_About"), null, "gtk-about");
            this.AboutAction.ShortLabel = Mono.Unix.Catalog.GetString("_About");
            w1.Add(this.AboutAction, null);
            this.ExportProjectToCSVFileAction = new Gtk.Action("ExportProjectToCSVFileAction", Mono.Unix.Catalog.GetString("Export Project To CSV File"), null, null);
            this.ExportProjectToCSVFileAction.Sensitive = false;
            this.ExportProjectToCSVFileAction.ShortLabel = Mono.Unix.Catalog.GetString("Export Project To CSV File");
            w1.Add(this.ExportProjectToCSVFileAction, null);
            this.UIManager.InsertActionGroup(w1, 0);
            this.AddAccelGroup(this.UIManager.AccelGroup);
            this.Name = "LongoMatch.Gui.MainWindow";
            this.Title = Mono.Unix.Catalog.GetString("LongoMatch");
            this.Icon = Gdk.Pixbuf.LoadFromResource("longomatch_logo.png");
            this.WindowPosition = ((Gtk.WindowPosition)(3));
            this.Gravity = ((Gdk.Gravity)(5));
            // Container child LongoMatch.Gui.MainWindow.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.menubox = new Gtk.VBox();
            this.menubox.Name = "menubox";
            this.menubox.Spacing = 6;
            // Container child menubox.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='NewPojectAction' action='NewPojectAction'/><menuitem name='OpenProjectAction' action='OpenProjectAction'/><menuitem name='SaveProjectAction' action='SaveProjectAction'/><menuitem name='CloseProjectAction' action='CloseProjectAction'/><separator/><menuitem name='QuitAction' action='QuitAction'/></menu><menu name='ToolsAction' action='ToolsAction'><menuitem name='ProjectsManagerAction' action='ProjectsManagerAction'/><menuitem name='TemplatesManagerAction' action='TemplatesManagerAction'/><menuitem name='ExportProjectToCSVFileAction' action='ExportProjectToCSVFileAction'/></menu><menu name='ViewAction' action='ViewAction'><menuitem name='FullScreenAction' action='FullScreenAction'/><menuitem name='PlaylistAction' action='PlaylistAction'/><menuitem name='CaptureModeAction' action='CaptureModeAction'/><menuitem name='AnalyzeModeAction' action='AnalyzeModeAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
            this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
            this.menubar1.Name = "menubar1";
            this.menubox.Add(this.menubar1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.menubox[this.menubar1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            this.vbox1.Add(this.menubox);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubox]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hpaned = new Gtk.HPaned();
            this.hpaned.CanFocus = true;
            this.hpaned.Name = "hpaned";
            this.hpaned.Position = 171;
            // Container child hpaned.Gtk.Paned+PanedChild
            this.leftbox = new Gtk.VBox();
            this.leftbox.Name = "leftbox";
            this.leftbox.Spacing = 6;
            // Container child leftbox.Gtk.Box+BoxChild
            this.treewidget1 = new LongoMatch.Gui.Component.TreeWidget();
            this.treewidget1.Events = ((Gdk.EventMask)(256));
            this.treewidget1.Name = "treewidget1";
            this.leftbox.Add(this.treewidget1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.leftbox[this.treewidget1]));
            w4.Position = 0;
            this.hpaned.Add(this.leftbox);
            Gtk.Paned.PanedChild w5 = ((Gtk.Paned.PanedChild)(this.hpaned[this.leftbox]));
            w5.Resize = false;
            // Container child hpaned.Gtk.Paned+PanedChild
            this.hpaned1 = new Gtk.HPaned();
            this.hpaned1.CanFocus = true;
            this.hpaned1.Name = "hpaned1";
            this.hpaned1.Position = 859;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.playerbin1 = new LongoMatch.Gui.PlayerBin();
            this.playerbin1.Events = ((Gdk.EventMask)(256));
            this.playerbin1.Name = "playerbin1";
            this.playerbin1.LogoMode = false;
            this.vbox5.Add(this.playerbin1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox5[this.playerbin1]));
            w6.Position = 0;
            // Container child vbox5.Gtk.Box+BoxChild
            this.timelinewidget1 = new LongoMatch.Gui.Component.TimeLineWidget();
            this.timelinewidget1.HeightRequest = 200;
            this.timelinewidget1.Events = ((Gdk.EventMask)(256));
            this.timelinewidget1.Name = "timelinewidget1";
            this.timelinewidget1.CurrentFrame = ((uint)(0));
            this.vbox5.Add(this.timelinewidget1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox5[this.timelinewidget1]));
            w7.Position = 1;
            w7.Expand = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.buttonswidget1 = new LongoMatch.Gui.Component.ButtonsWidget();
            this.buttonswidget1.Events = ((Gdk.EventMask)(256));
            this.buttonswidget1.Name = "buttonswidget1";
            this.vbox5.Add(this.buttonswidget1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox5[this.buttonswidget1]));
            w8.Position = 2;
            w8.Expand = false;
            this.hpaned1.Add(this.vbox5);
            Gtk.Paned.PanedChild w9 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vbox5]));
            w9.Resize = false;
            w9.Shrink = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.rightvbox = new Gtk.VBox();
            this.rightvbox.WidthRequest = 100;
            this.rightvbox.Name = "rightvbox";
            this.rightvbox.Spacing = 6;
            // Container child rightvbox.Gtk.Box+BoxChild
            this.noteswidget1 = new LongoMatch.Gui.Component.NotesWidget();
            this.noteswidget1.Events = ((Gdk.EventMask)(256));
            this.noteswidget1.Name = "noteswidget1";
            this.rightvbox.Add(this.noteswidget1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.rightvbox[this.noteswidget1]));
            w10.Position = 1;
            // Container child rightvbox.Gtk.Box+BoxChild
            this.playlistwidget2 = new LongoMatch.Gui.Component.PlayListWidget();
            this.playlistwidget2.WidthRequest = 100;
            this.playlistwidget2.Events = ((Gdk.EventMask)(256));
            this.playlistwidget2.Name = "playlistwidget2";
            this.rightvbox.Add(this.playlistwidget2);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.rightvbox[this.playlistwidget2]));
            w11.Position = 2;
            this.hpaned1.Add(this.rightvbox);
            Gtk.Paned.PanedChild w12 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.rightvbox]));
            w12.Resize = false;
            w12.Shrink = false;
            this.hpaned.Add(this.hpaned1);
            Gtk.Paned.PanedChild w13 = ((Gtk.Paned.PanedChild)(this.hpaned[this.hpaned1]));
            w13.Resize = false;
            w13.Shrink = false;
            this.vbox1.Add(this.hpaned);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox1[this.hpaned]));
            w14.Position = 1;
            // Container child vbox1.Gtk.Box+BoxChild
            this.statusbar1 = new Gtk.Statusbar();
            this.statusbar1.Name = "statusbar1";
            this.statusbar1.Spacing = 6;
            // Container child statusbar1.Gtk.Box+BoxChild
            this.videoprogressbar = new Gtk.ProgressBar();
            this.videoprogressbar.Name = "videoprogressbar";
            this.videoprogressbar.Text = Mono.Unix.Catalog.GetString("Creating video...");
            this.statusbar1.Add(this.videoprogressbar);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.statusbar1[this.videoprogressbar]));
            w15.Position = 3;
            w15.Expand = false;
            w15.Fill = false;
            this.vbox1.Add(this.statusbar1);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
            w16.Position = 2;
            w16.Expand = false;
            w16.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 1259;
            this.DefaultHeight = 537;
            this.leftbox.Hide();
            this.timelinewidget1.Hide();
            this.buttonswidget1.Hide();
            this.noteswidget1.Hide();
            this.playlistwidget2.Hide();
            this.rightvbox.Hide();
            this.videoprogressbar.Hide();
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
            this.NewPojectAction.Activated += new System.EventHandler(this.OnNewActivated);
            this.OpenProjectAction.Activated += new System.EventHandler(this.OnOpenActivated);
            this.QuitAction.Activated += new System.EventHandler(this.OnQuitActivated);
            this.CloseProjectAction.Activated += new System.EventHandler(this.OnCloseActivated);
            this.ProjectsManagerAction.Activated += new System.EventHandler(this.OnDatabaseManagerActivated);
            this.TemplatesManagerAction.Activated += new System.EventHandler(this.OnSectionsTemplatesManagerActivated);
            this.FullScreenAction.Toggled += new System.EventHandler(this.OnFullScreenActionToggled);
            this.PlaylistAction.Toggled += new System.EventHandler(this.OnPlaylistActionToggled);
            this.CaptureModeAction.Toggled += new System.EventHandler(this.OnCaptureModeActionToggled);
            this.SaveProjectAction.Activated += new System.EventHandler(this.OnSaveProjectActionActivated);
            this.AboutAction.Activated += new System.EventHandler(this.OnAboutActionActivated);
            this.ExportProjectToCSVFileAction.Activated += new System.EventHandler(this.OnExportProjectToCSVFileActionActivated);
            this.treewidget1.TimeNodeSelected += new LongoMatch.Handlers.TimeNodeSelectedHandler(this.OnTimeNodeSelected);
            this.playerbin1.Error += new LongoMatch.Video.Handlers.ErrorHandler(this.OnPlayerbin1Error);
            this.playerbin1.SegmentClosedEvent += new LongoMatch.Video.Handlers.SegmentClosedHandler(this.OnSegmentClosedEvent);
            this.timelinewidget1.TimeNodeSelected += new LongoMatch.Handlers.TimeNodeSelectedHandler(this.OnTimeNodeSelected);
        }
    }
}
