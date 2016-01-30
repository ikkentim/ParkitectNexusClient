
// This file has been generated by the GUI designer. Do not modify.
namespace ParkitectNexus.Client.Linux
{
    public partial class BlueprintPage
    {
        private global::Gtk.HBox hbox2;
        
        private global::Gtk.HPaned BlueprintPane;
        
        private global::Gtk.ScrolledWindow scrolledwindow2;
        
        private global::Gtk.IconView blueprints;
        
        private global::Gtk.ScrolledWindow scrolledwindow1;
        
        private global::Gtk.VBox vbox3;
        
        private global::Gtk.Alignment alignment3;
        
        private global::Gtk.Label blueprintName;
        
        private global::Gtk.Alignment alignment2;
        
        private global::Gtk.Image blueprintImage;

        protected virtual void Build ()
        {
            global::Stetic.Gui.Initialize (this);
            // Widget ParkitectNexus.Client.Linux.BlueprintPage
            global::Stetic.BinContainer.Attach (this);
            this.Name = "ParkitectNexus.Client.Linux.BlueprintPage";
            // Container child ParkitectNexus.Client.Linux.BlueprintPage.Gtk.Container+ContainerChild
            this.hbox2 = new global::Gtk.HBox ();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.BlueprintPane = new global::Gtk.HPaned ();
            this.BlueprintPane.CanFocus = true;
            this.BlueprintPane.Name = "BlueprintPane";
            this.BlueprintPane.Position = 282;
            // Container child BlueprintPane.Gtk.Paned+PanedChild
            this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
            this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.blueprints = new global::Gtk.IconView ();
            this.blueprints.CanFocus = true;
            this.blueprints.Name = "blueprints";
            this.scrolledwindow2.Add (this.blueprints);
            this.BlueprintPane.Add (this.scrolledwindow2);
            global::Gtk.Paned.PanedChild w2 = ((global::Gtk.Paned.PanedChild)(this.BlueprintPane [this.scrolledwindow2]));
            w2.Resize = false;
            // Container child BlueprintPane.Gtk.Paned+PanedChild
            this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
            this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            global::Gtk.Viewport w3 = new global::Gtk.Viewport ();
            w3.ShadowType = ((global::Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.vbox3 = new global::Gtk.VBox ();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
            this.alignment3.Name = "alignment3";
            this.alignment3.LeftPadding = ((uint)(10));
            this.alignment3.TopPadding = ((uint)(8));
            this.alignment3.BottomPadding = ((uint)(8));
            // Container child alignment3.Gtk.Container+ContainerChild
            this.blueprintName = new global::Gtk.Label ();
            this.blueprintName.Name = "blueprintName";
            this.blueprintName.Xalign = 0F;
            this.blueprintName.LabelProp = global::Mono.Unix.Catalog.GetString ("---");
            this.alignment3.Add (this.blueprintName);
            this.vbox3.Add (this.alignment3);
            global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment3]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            w5.Padding = ((uint)(7));
            // Container child vbox3.Gtk.Box+BoxChild
            this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
            this.alignment2.Name = "alignment2";
            this.alignment2.LeftPadding = ((uint)(10));
            this.alignment2.TopPadding = ((uint)(10));
            this.alignment2.RightPadding = ((uint)(10));
            this.alignment2.BottomPadding = ((uint)(10));
            // Container child alignment2.Gtk.Container+ContainerChild
            this.blueprintImage = new global::Gtk.Image ();
            this.blueprintImage.Name = "blueprintImage";
            this.blueprintImage.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ParkitectNexus.Client.Linux.parkitect_logo.png");
            this.alignment2.Add (this.blueprintImage);
            this.vbox3.Add (this.alignment2);
            global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment2]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            w3.Add (this.vbox3);
            this.scrolledwindow1.Add (w3);
            this.BlueprintPane.Add (this.scrolledwindow1);
            this.hbox2.Add (this.BlueprintPane);
            global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.BlueprintPane]));
            w11.Position = 0;
            this.Add (this.hbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll ();
            }
            this.Hide ();
        }
    }
}
