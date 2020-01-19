using System;
using System.IO;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public string openfile;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }
    private ResponseType Savequestion()
    {
        MessageDialog md1 = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Do you want to save changes?");
        ResponseType w = (ResponseType)md1.Run();
        md1.Destroy();
        return w;
    }
    private void Save()
    {
        if (string.IsNullOrEmpty(openfile))
        {
            Gtk.FileChooserDialog fileChooser =
                   new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Save, "Cancel", ResponseType.Cancel, "Save", ResponseType.Accept); if (fileChooser.Run() == (int)ResponseType.Accept)
            {
                string save = textview1.Buffer.GetText(textview1.Buffer.StartIter, textview1.Buffer.EndIter, true);
                openfile = fileChooser.Filename;
                File.WriteAllText(fileChooser.Filename, save);
                fileChooser.Destroy();
            }
        }
        else
        {
            string save = textview1.Buffer.GetText(textview1.Buffer.StartIter, textview1.Buffer.EndIter, true);
            File.WriteAllText(openfile, save);
        }
    }
    private void Open()
    {
        Gtk.FileChooserDialog fileChooser =
                       new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Open, "Cancel", ResponseType.Cancel, "Open", ResponseType.Accept);
        if (fileChooser.Run() == (int)ResponseType.Accept)
        {
            string content = File.ReadAllText(fileChooser.Filename);
            openfile = fileChooser.Filename;
            textview1.Buffer.Text = content;
            textview1.Buffer.Modified = false;
            fileChooser.Destroy();
        }
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        if (textview1.Buffer.Modified == true)
        {
            ResponseType wynik = Savequestion();
            if (wynik == ResponseType.Yes)
            {
                Save();
            }
        }
            Gtk.Application.Quit();
            a.RetVal = true;
    }

    protected void OnExitActionActivated(object sender, EventArgs e)
    {
        DeleteEventArgs a=null;
        OnDeleteEvent(sender, a);

    }

    protected void OnNewActionActivated(object sender, EventArgs e)
    {
        if (textview1.Buffer.Modified == true)
        {
            ResponseType wynik = Savequestion();
            if (wynik == ResponseType.Yes)
            Save();
        }
        textview1.Buffer.Clear();
        openfile = null;
        textview1.Buffer.Modified = false;
    }

    protected void OnOpenActionActivated(object sender, EventArgs e)
    {
        if (textview1.Buffer.Modified == true)
        {
            ResponseType wynik = Savequestion();
            if (wynik == ResponseType.Yes)
            {
                Save();
            }
        }
        Open();
    }

    protected void OnSaveActionActivated(object sender, EventArgs e)
    {
        Save();
        textview1.Buffer.Modified = false;
    }

    protected void OnCopyActionActivated(object sender, EventArgs e)
    {
        var schowek = textview1.GetClipboard(Gdk.Selection.Clipboard);
        textview1.Buffer.CopyClipboard(schowek);
    }

    protected void OnPasteActionActivated(object sender, EventArgs e)
    {
        var schowek = textview1.GetClipboard(Gdk.Selection.Clipboard);
        textview1.Buffer.PasteClipboard(schowek);
    }

    protected void OnCutActionActivated(object sender, EventArgs e)
    {
        var schowek = textview1.GetClipboard(Gdk.Selection.Clipboard);
        textview1.Buffer.CutClipboard(schowek, true);
    }

    protected void OnSelectAllActionActivated(object sender, EventArgs e)
    {
        textview1.Buffer.SelectRange(textview1.Buffer.StartIter, textview1.Buffer.EndIter);
    }

    protected void OnFontAction1Activated(object sender, EventArgs e)
    {
        FontSelectionDialog font = new FontSelectionDialog("Select font name");
        font.Response += delegate (object o, ResponseArgs resp) {

            if (resp.ResponseId == ResponseType.Ok)
            {
                Pango.FontDescription fontsel =
                    Pango.FontDescription.FromString(font.FontName);
                textview1.ModifyFont(fontsel);
            }
        };

        font.Run();
        font.Destroy();
    }

    protected void OnAboutActionActivated(object sender, EventArgs e)
    {
        AboutDialog about = new AboutDialog();
        about.ProgramName = "Notepad";
        about.Copyright = "(c) Paweł Bielecki";
        about.Website = "http://bieleckipawel.pl";
        about.Run();
        about.Destroy();
    }
}
