
// This file has been generated by the GUI designer. Do not modify.
namespace ParkitectNexus.Client.Linux
{
	public partial class ModsPage
	{
		private global::Gtk.Alignment alignment3;
		
		private global::Gtk.HPaned OptionsPane;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Button btnInstallMod;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.NodeView listViewMods;
		
		private global::Gtk.VBox vbox6;
		
		private global::Gtk.Frame optionsFrame;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.Label lblModName;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Label lblModVersion;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Label label13;
		
		private global::Gtk.EventBox eventViewParkitectNexus;
		
		private global::Gtk.Label lblViewOnParkitectNexusWebsite;
		
		private global::Gtk.HSeparator hseparator3;
		
		private global::Gtk.Label lblDevelopmentStatus;
		
		private global::Gtk.HButtonBox hbuttonbox3;
		
		private global::Gtk.Button btnRecompile;
		
		private global::Gtk.Button btnUpdate;
		
		private global::Gtk.Button btnUninstall;
		
		private global::Gtk.Label GtkLabel6;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ParkitectNexus.Client.Linux.ModsPage
			global::Stetic.BinContainer.Attach (this);
			this.Name = "ParkitectNexus.Client.Linux.ModsPage";
			// Container child ParkitectNexus.Client.Linux.ModsPage.Gtk.Container+ContainerChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.WidthRequest = 575;
			this.alignment3.HeightRequest = 430;
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(10));
			this.alignment3.TopPadding = ((uint)(10));
			this.alignment3.RightPadding = ((uint)(10));
			this.alignment3.BottomPadding = ((uint)(10));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.OptionsPane = new global::Gtk.HPaned ();
			this.OptionsPane.CanFocus = true;
			this.OptionsPane.Name = "OptionsPane";
			this.OptionsPane.Position = 330;
			// Container child OptionsPane.Gtk.Paned+PanedChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.btnInstallMod = new global::Gtk.Button ();
			this.btnInstallMod.CanFocus = true;
			this.btnInstallMod.Name = "btnInstallMod";
			this.btnInstallMod.UseUnderline = true;
			this.btnInstallMod.Label = global::Mono.Unix.Catalog.GetString ("Install Asset");
			this.vbox2.Add (this.btnInstallMod);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnInstallMod]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.listViewMods = new global::Gtk.NodeView ();
			this.listViewMods.CanFocus = true;
			this.listViewMods.Name = "listViewMods";
			this.GtkScrolledWindow.Add (this.listViewMods);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w3.Position = 1;
			this.OptionsPane.Add (this.vbox2);
			global::Gtk.Paned.PanedChild w4 = ((global::Gtk.Paned.PanedChild)(this.OptionsPane [this.vbox2]));
			w4.Resize = false;
			// Container child OptionsPane.Gtk.Paned+PanedChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.optionsFrame = new global::Gtk.Frame ();
			this.optionsFrame.Name = "optionsFrame";
			this.optionsFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child optionsFrame.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Mod:");
			this.hbox6.Add (this.label9);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label9]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.lblModName = new global::Gtk.Label ();
			this.lblModName.Name = "lblModName";
			this.lblModName.LabelProp = global::Mono.Unix.Catalog.GetString ("label10");
			this.hbox6.Add (this.lblModName);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lblModName]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox4.Add (this.hbox6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox6]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Version:");
			this.hbox7.Add (this.label11);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label11]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.lblModVersion = new global::Gtk.Label ();
			this.lblModVersion.Name = "lblModVersion";
			this.lblModVersion.LabelProp = global::Mono.Unix.Catalog.GetString ("label10");
			this.lblModVersion.UseUnderline = true;
			this.hbox7.Add (this.lblModVersion);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.lblModVersion]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox4.Add (this.hbox7);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox7]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Website:");
			this.hbox8.Add (this.label13);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label13]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.eventViewParkitectNexus = new global::Gtk.EventBox ();
			this.eventViewParkitectNexus.Name = "eventViewParkitectNexus";
			// Container child eventViewParkitectNexus.Gtk.Container+ContainerChild
			this.lblViewOnParkitectNexusWebsite = new global::Gtk.Label ();
			this.lblViewOnParkitectNexusWebsite.Name = "lblViewOnParkitectNexusWebsite";
			this.lblViewOnParkitectNexusWebsite.LabelProp = global::Mono.Unix.Catalog.GetString ("View on ParkitectNexus");
			this.lblViewOnParkitectNexusWebsite.UseUnderline = true;
			this.eventViewParkitectNexus.Add (this.lblViewOnParkitectNexusWebsite);
			this.hbox8.Add (this.eventViewParkitectNexus);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.eventViewParkitectNexus]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox4.Add (this.hbox8);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox8]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.vbox4.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hseparator3]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			w15.Padding = ((uint)(15));
			// Container child vbox4.Gtk.Box+BoxChild
			this.lblDevelopmentStatus = new global::Gtk.Label ();
			this.lblDevelopmentStatus.Name = "lblDevelopmentStatus";
			this.lblDevelopmentStatus.LabelProp = global::Mono.Unix.Catalog.GetString ("MOD IN DEVELOPMENT");
			this.vbox4.Add (this.lblDevelopmentStatus);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.lblDevelopmentStatus]));
			w16.Position = 5;
			w16.Expand = false;
			w16.Fill = false;
			w16.Padding = ((uint)(5));
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbuttonbox3 = new global::Gtk.HButtonBox ();
			this.hbuttonbox3.Name = "hbuttonbox3";
			this.hbuttonbox3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
			this.btnRecompile = new global::Gtk.Button ();
			this.btnRecompile.CanFocus = true;
			this.btnRecompile.Name = "btnRecompile";
			this.btnRecompile.UseUnderline = true;
			this.btnRecompile.Label = global::Mono.Unix.Catalog.GetString ("Recompile");
			this.hbuttonbox3.Add (this.btnRecompile);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox3 [this.btnRecompile]));
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
			this.btnUpdate = new global::Gtk.Button ();
			this.btnUpdate.CanFocus = true;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseUnderline = true;
			this.btnUpdate.Label = global::Mono.Unix.Catalog.GetString ("Update");
			this.hbuttonbox3.Add (this.btnUpdate);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox3 [this.btnUpdate]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox4.Add (this.hbuttonbox3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbuttonbox3]));
			w19.Position = 6;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.btnUninstall = new global::Gtk.Button ();
			this.btnUninstall.CanFocus = true;
			this.btnUninstall.Name = "btnUninstall";
			this.btnUninstall.UseUnderline = true;
			this.btnUninstall.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.vbox4.Add (this.btnUninstall);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.btnUninstall]));
			w20.Position = 7;
			w20.Expand = false;
			w20.Fill = false;
			this.GtkAlignment2.Add (this.vbox4);
			this.optionsFrame.Add (this.GtkAlignment2);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Options</b>");
			this.GtkLabel6.UseMarkup = true;
			this.optionsFrame.LabelWidget = this.GtkLabel6;
			this.vbox6.Add (this.optionsFrame);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.optionsFrame]));
			w23.Position = 0;
			this.OptionsPane.Add (this.vbox6);
			this.alignment3.Add (this.OptionsPane);
			this.Add (this.alignment3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.btnRecompile.Clicked += new global::System.EventHandler (this.Recompile);
			this.btnUpdate.Clicked += new global::System.EventHandler (this.Update);
			this.btnUninstall.Clicked += new global::System.EventHandler (this.UninstallMod);
		}
	}
}
