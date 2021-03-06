
// This file has been generated by the GUI designer. Do not modify.
namespace blue_patcher
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Frame frame2;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.Entry pathField;
		private global::Gtk.Label label2;
		private global::Gtk.FileChooserButton ChooseFile;
		private global::Gtk.Button Patch;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textView;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget blue_patcher.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "blue_patcher.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Resizable = false;
			this.AllowGrow = false;
			this.Gravity = ((global::Gdk.Gravity)(5));
			// Container child blue_patcher.MainWindow.Gtk.Container+ContainerChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.pathField = new global::Gtk.Entry ();
			this.pathField.WidthRequest = 220;
			this.pathField.CanFocus = true;
			this.pathField.Name = "pathField";
			this.pathField.IsEditable = true;
			this.pathField.InvisibleChar = '●';
			this.fixed2.Add (this.pathField);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.pathField]));
			w2.X = 72;
			w2.Y = 6;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Choose file");
			this.fixed2.Add (this.label2);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.label2]));
			w3.X = 5;
			w3.Y = 9;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.ChooseFile = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select A File"), ((global::Gtk.FileChooserAction)(0)));
			this.ChooseFile.WidthRequest = 25;
			this.ChooseFile.Name = "ChooseFile";
			this.fixed2.Add (this.ChooseFile);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.ChooseFile]));
			w4.X = 298;
			w4.Y = 5;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.Patch = new global::Gtk.Button ();
			this.Patch.WidthRequest = 317;
			this.Patch.HeightRequest = 38;
			this.Patch.CanFocus = true;
			this.Patch.Name = "Patch";
			this.Patch.UseUnderline = true;
			this.Patch.Label = global::Mono.Unix.Catalog.GetString ("Patch!");
			this.fixed2.Add (this.Patch);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.Patch]));
			w5.X = 5;
			w5.Y = 40;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textView = new global::Gtk.TextView ();
			this.textView.WidthRequest = 292;
			this.textView.HeightRequest = 163;
			this.textView.CanFocus = true;
			this.textView.Name = "textView";
			this.textView.Editable = false;
			this.textView.CursorVisible = false;
			this.GtkScrolledWindow.Add (this.textView);
			this.fixed2.Add (this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.GtkScrolledWindow]));
			w7.X = 5;
			w7.Y = 88;
			this.frame2.Add (this.fixed2);
			this.Add (this.frame2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 343;
			this.DefaultHeight = 320;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.ChooseFile.SelectionChanged += new global::System.EventHandler (this.OnChooseFileSelectionChanged);
			this.Patch.Clicked += new global::System.EventHandler (this.OnPatchClicked);
		}
	}
}
