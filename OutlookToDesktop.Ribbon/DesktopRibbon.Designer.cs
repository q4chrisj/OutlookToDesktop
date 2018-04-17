namespace OutlookAddIn
{
    partial class DesktopRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DesktopRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.desktopTab = this.Factory.CreateRibbonTab();
            this.desktopGroup = this.Factory.CreateRibbonGroup();
            this.sndButton = this.Factory.CreateRibbonButton();
            this.desktopTab.SuspendLayout();
            this.desktopGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // desktopTab
            // 
            this.desktopTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.desktopTab.ControlId.OfficeId = "TabAppointment";
            this.desktopTab.Groups.Add(this.desktopGroup);
            this.desktopTab.Label = "TabAppointment";
            this.desktopTab.Name = "desktopTab";
            // 
            // desktopGroup
            // 
            this.desktopGroup.Items.Add(this.sndButton);
            this.desktopGroup.Label = "Q4 Desktop Actions";
            this.desktopGroup.Name = "desktopGroup";
            this.desktopGroup.Position = this.Factory.RibbonPosition.BeforeOfficeId("GroupClipboard");
            // 
            // sndButton
            // 
            this.sndButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sndButton.Image = global::OutlookAddIn.Properties.Resources.sync_2pt;
            this.sndButton.Label = "Sync ";
            this.sndButton.Name = "sndButton";
            this.sndButton.ShowImage = true;
            // 
            // DesktopRibbon
            // 
            this.Name = "DesktopRibbon";
            this.RibbonType = "Microsoft.Outlook.Appointment";
            this.Tabs.Add(this.desktopTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.desktopTab.ResumeLayout(false);
            this.desktopTab.PerformLayout();
            this.desktopGroup.ResumeLayout(false);
            this.desktopGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab desktopTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup desktopGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sndButton;
    }

    partial class ThisRibbonCollection
    {
        internal DesktopRibbon Ribbon
        {
            get { return this.GetRibbon<DesktopRibbon>(); }
        }
    }
}
