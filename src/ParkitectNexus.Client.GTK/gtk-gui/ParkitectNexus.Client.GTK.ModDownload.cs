
// This file has been generated by the GUI designer. Do not modify.
namespace ParkitectNexus.Client.GTK
{
	public partial class ModDownload
	{
		private global::Gtk.Alignment alignment3;
		
		private global::Gtk.Label Mod_Name;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.ProgressBar Progress_Bar;
		
		private global::Gtk.Alignment alignment2;
		
		private global::Gtk.Label Progress_Label;
		
		private global::Gtk.Button Finished;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ParkitectNexus.Client.GTK.ModDownload
			this.Name = "ParkitectNexus.Client.GTK.ModDownload";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child ParkitectNexus.Client.GTK.ModDownload.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(20));
			this.alignment3.TopPadding = ((uint)(30));
			this.alignment3.RightPadding = ((uint)(20));
			this.alignment3.BottomPadding = ((uint)(20));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.Mod_Name = new global::Gtk.Label ();
			this.Mod_Name.Name = "Mod_Name";
			this.Mod_Name.Xalign = 0F;
			this.Mod_Name.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			this.alignment3.Add (this.Mod_Name);
			w1.Add (this.alignment3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment3]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(10));
			this.alignment1.RightPadding = ((uint)(10));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.Progress_Bar = new global::Gtk.ProgressBar ();
			this.Progress_Bar.Name = "Progress_Bar";
			this.alignment1.Add (this.Progress_Bar);
			w1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment1]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(20));
			this.alignment2.TopPadding = ((uint)(10));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.Progress_Label = new global::Gtk.Label ();
			this.Progress_Label.Name = "Progress_Label";
			this.Progress_Label.Xalign = 0F;
			this.Progress_Label.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.alignment2.Add (this.Progress_Label);
			w1.Add (this.alignment2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment2]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Internal child ParkitectNexus.Client.GTK.ModDownload.ActionArea
			global::Gtk.HButtonBox w8 = this.ActionArea;
			w8.Name = "dialog1_ActionArea";
			w8.Spacing = 10;
			w8.BorderWidth = ((uint)(5));
			w8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.Finished = new global::Gtk.Button ();
			this.Finished.Sensitive = false;
			this.Finished.CanDefault = true;
			this.Finished.CanFocus = true;
			this.Finished.Name = "Finished";
			this.Finished.UseUnderline = true;
			this.Finished.Label = global::Mono.Unix.Catalog.GetString ("Finished");
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			this.Finished.Image = w9;
			this.AddActionWidget (this.Finished, -10);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.Finished]));
			w10.Expand = false;
			w10.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 175;
			this.Show ();
		}
	}
}
