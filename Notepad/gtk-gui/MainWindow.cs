
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action NewAction;

	private global::Gtk.Action OpenAction;

	private global::Gtk.Action SaveAction;

	private global::Gtk.Action EditAction;

	private global::Gtk.Action SelectAllAction;

	private global::Gtk.Action CopyAction;

	private global::Gtk.Action PasteAction;

	private global::Gtk.Action CutAction;

	private global::Gtk.Action FormatAction;

	private global::Gtk.Action FontAction1;

	private global::Gtk.Action HelpAction;

	private global::Gtk.Action AboutAction;

	private global::Gtk.Action ExitAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction, null);
		this.NewAction = new global::Gtk.Action("NewAction", global::Mono.Unix.Catalog.GetString("New"), null, null);
		this.NewAction.ShortLabel = global::Mono.Unix.Catalog.GetString("New");
		w1.Add(this.NewAction, null);
		this.OpenAction = new global::Gtk.Action("OpenAction", global::Mono.Unix.Catalog.GetString("Open"), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Open");
		w1.Add(this.OpenAction, null);
		this.SaveAction = new global::Gtk.Action("SaveAction", global::Mono.Unix.Catalog.GetString("Save"), null, null);
		this.SaveAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save");
		w1.Add(this.SaveAction, null);
		this.EditAction = new global::Gtk.Action("EditAction", global::Mono.Unix.Catalog.GetString("Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Edit");
		w1.Add(this.EditAction, null);
		this.SelectAllAction = new global::Gtk.Action("SelectAllAction", global::Mono.Unix.Catalog.GetString("Select all"), null, null);
		this.SelectAllAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Select all");
		w1.Add(this.SelectAllAction, null);
		this.CopyAction = new global::Gtk.Action("CopyAction", global::Mono.Unix.Catalog.GetString("Copy"), null, null);
		this.CopyAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Copy");
		w1.Add(this.CopyAction, null);
		this.PasteAction = new global::Gtk.Action("PasteAction", global::Mono.Unix.Catalog.GetString("Paste"), null, null);
		this.PasteAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Paste");
		w1.Add(this.PasteAction, null);
		this.CutAction = new global::Gtk.Action("CutAction", global::Mono.Unix.Catalog.GetString("Cut"), null, null);
		this.CutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Cut");
		w1.Add(this.CutAction, null);
		this.FormatAction = new global::Gtk.Action("FormatAction", global::Mono.Unix.Catalog.GetString("Format"), null, null);
		this.FormatAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Format");
		w1.Add(this.FormatAction, null);
		this.FontAction1 = new global::Gtk.Action("FontAction1", global::Mono.Unix.Catalog.GetString("Font"), null, null);
		this.FontAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Font");
		w1.Add(this.FontAction1, null);
		this.HelpAction = new global::Gtk.Action("HelpAction", global::Mono.Unix.Catalog.GetString("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Help");
		w1.Add(this.HelpAction, null);
		this.AboutAction = new global::Gtk.Action("AboutAction", global::Mono.Unix.Catalog.GetString("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.AboutAction, null);
		this.ExitAction = new global::Gtk.Action("ExitAction", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
<<<<<<< HEAD
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
=======
		this.Title = global::Mono.Unix.Catalog.GetString("Notepad");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource("Notepad.icon.ico");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.DefaultWidth = 640;
		this.DefaultHeight = 480;
>>>>>>> 19a519c... Wszystkie funkcje działają
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='SaveAction' action='SaveAction'/><menuitem name='NewAction' action='NewAction'/><menuitem name='OpenAction' action='OpenAction'/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='EditAction' action='EditAction'><menuitem name='SelectAllAction' action='SelectAllAction'/><menuitem name='CopyAction' action='CopyAction'/><menuitem name='PasteAction' action='PasteAction'/><menuitem name='CutAction' action='CutAction'/></menu><menu name='FormatAction' action='FormatAction'><menuitem name='FontAction1' action='FontAction1'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add(this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add(this.textview1);
		this.vbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w4.Position = 1;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
<<<<<<< HEAD
		this.DefaultWidth = 463;
		this.DefaultHeight = 300;
=======
>>>>>>> 19a519c... Wszystkie funkcje działają
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.NewAction.Activated += new global::System.EventHandler(this.OnNewActionActivated);
		this.OpenAction.Activated += new global::System.EventHandler(this.OnOpenActionActivated);
		this.SaveAction.Activated += new global::System.EventHandler(this.OnSaveActionActivated);
		this.SelectAllAction.Activated += new global::System.EventHandler(this.OnSelectAllActionActivated);
		this.CopyAction.Activated += new global::System.EventHandler(this.OnCopyActionActivated);
		this.PasteAction.Activated += new global::System.EventHandler(this.OnPasteActionActivated);
		this.CutAction.Activated += new global::System.EventHandler(this.OnCutActionActivated);
<<<<<<< HEAD
=======
		this.FontAction1.Activated += new global::System.EventHandler(this.OnFontAction1Activated);
		this.AboutAction.Activated += new global::System.EventHandler(this.OnAboutActionActivated);
>>>>>>> 19a519c... Wszystkie funkcje działają
		this.ExitAction.Activated += new global::System.EventHandler(this.OnExitActionActivated);
	}
}