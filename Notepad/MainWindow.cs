using System;
using System.IO;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        if (textview1.Buffer.Modified == true)
        {
            MessageDialog md1 = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Do you want to save changes?");
            ResponseType wynik = (ResponseType)md1.Run();
            md1.Destroy();
            if (wynik == ResponseType.No)
            {
                Gtk.Application.Quit();
                a.RetVal = true;
            }
            else if (wynik == ResponseType.Yes)
            {
                Gtk.FileChooserDialog fileChooser =
                       new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Save, "Cancel", ResponseType.Cancel, "Save", ResponseType.Accept); if (fileChooser.Run() == (int)ResponseType.Accept)
                {
                    string save = textview1.Buffer.GetText(textview1.Buffer.StartIter, textview1.Buffer.EndIter, true);
                    File.WriteAllText(fileChooser.Filename, save);
                    fileChooser.Destroy();
                    Gtk.Application.Quit();
                    a.RetVal = true;
                }
            }
        }
    }

    protected void OnExitActionActivated(object sender, EventArgs e)
    {
        if (textview1.Buffer.Modified == true)
        {
            MessageDialog md1 = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Do you want to save changes?");
            ResponseType wynik = (ResponseType)md1.Run();
            md1.Destroy();
            if (wynik == ResponseType.No)
            {
                Gtk.Application.Quit();
            }
            else if (wynik == ResponseType.Yes)
            {
                Gtk.FileChooserDialog fileChooser =
                        new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Save, "Cancel", ResponseType.Cancel, "Save", ResponseType.Accept);
                if (fileChooser.Run() == (int)ResponseType.Accept)
                {
                    string save = textview1.Buffer.GetText(textview1.Buffer.StartIter, textview1.Buffer.EndIter, true);
                    File.WriteAllText(fileChooser.Filename, save);
                    fileChooser.Destroy();
                    Gtk.Application.Quit();
                }
            }
        }
        else
        {
            Gtk.Application.Quit();
        }


    }

    protected void OnNewActionActivated(object sender, EventArgs e)
    {
        if (textview1.Buffer.Modified == true)
        {
            MessageDialog md1 = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Do you want to save changes?");
            ResponseType wynik = (ResponseType)md1.Run();
            md1.Destroy();
            if (wynik == ResponseType.No)
            {
                textview1.Buffer.Clear();
            }
            else if (wynik == ResponseType.Yes)
            {
                Gtk.FileChooserDialog fileChooser =
                       new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Save, "Cancel", ResponseType.Cancel, "Save", ResponseType.Accept);
                if (fileChooser.Run() == (int)ResponseType.Accept)
                {
                    string save = textview1.Buffer.GetText(textview1.Buffer.StartIter, textview1.Buffer.EndIter, true);
                    File.WriteAllText(fileChooser.Filename, save);
                    fileChooser.Destroy();
                    textview1.Buffer.Clear();
                    textview1.Buffer.Modified = false;
                }
            }

            else
            {
                textview1.Buffer.Clear();
                textview1.Buffer.Modified = false;
            }

        }
    }

    protected void OnOpenActionActivated(object sender, EventArgs e)
    {
        if (textview1.Buffer.Modified == true)
        {
            MessageDialog md1 = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Do you want to save changes?");
            ResponseType wynik = (ResponseType)md1.Run();
            md1.Destroy();
            if (wynik == ResponseType.No)
            {
                Gtk.FileChooserDialog fileChooser =
                       new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Open, "Cancel", ResponseType.Cancel, "Open", ResponseType.Accept);
                if (fileChooser.Run() == (int)ResponseType.Accept)
                {
                    string content = File.ReadAllText(fileChooser.Filename);
                    textview1.Buffer.Text = content;
                    textview1.Buffer.Modified = false;
                    fileChooser.Destroy();
                }
            }
            else if (wynik == ResponseType.Yes)
            {
                Gtk.FileChooserDialog fileChooser =
                       new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Save, "Cancel", ResponseType.Cancel, "Save", ResponseType.Accept);
                if (fileChooser.Run() == (int)ResponseType.Accept)
                {
                    string save = textview1.Buffer.GetText(textview1.Buffer.StartIter, textview1.Buffer.EndIter, true);
                    File.WriteAllText(fileChooser.Filename, save);
                    fileChooser.Destroy();
                    textview1.Buffer.Clear();
                    Gtk.FileChooserDialog fileChooser1 =
                       new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Open, "Cancel", ResponseType.Cancel, "Open", ResponseType.Accept);
                    if (fileChooser1.Run() == (int)ResponseType.Accept)
                    {
                        string content = File.ReadAllText(fileChooser1.Filename);
                        textview1.Buffer.Text = content;
                        textview1.Buffer.Modified = false;
                        fileChooser1.Destroy();
                    }
                }
            }
        }
        else
        {
            Gtk.FileChooserDialog fileChooser1 =
                                   new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Open, "Cancel", ResponseType.Cancel, "Open", ResponseType.Accept);
            if (fileChooser1.Run() == (int)ResponseType.Accept)
            {
                string content = File.ReadAllText(fileChooser1.Filename);
                textview1.Buffer.Text = content;
                textview1.Buffer.Modified = false;
                fileChooser1.Destroy();
            }
        }
    }

    protected void OnSaveActionActivated(object sender, EventArgs e)
    {
        FileChooserDialog fileChooser =
                       new Gtk.FileChooserDialog("Select file", this, FileChooserAction.Save, "Cancel", ResponseType.Cancel, "Save", ResponseType.Accept);
        if (fileChooser.Run() == (int)ResponseType.Accept)
        {
            string save = textview1.Buffer.GetText(textview1.Buffer.StartIter, textview1.Buffer.EndIter, true);
            File.WriteAllText(fileChooser.Filename, save);
            fileChooser.Destroy();
            textview1.Buffer.Modified = false;
        }
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
