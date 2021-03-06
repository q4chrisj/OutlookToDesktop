﻿using Microsoft.Office.Interop.Outlook;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OutlookAddIn
{
    [ComVisible(true)]
    public partial class OptionsPage : UserControl, PropertyPage
    {
        const int captionDisplayId = -518;
        bool isDirty = false;

        public OptionsPage()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            txtEmail.Text = Properties.Settings.Default.Email ?? "";
            txtPassword.Text = Properties.Settings.Default.Password ?? "";

            base.OnLoad(e);
        }


        public void GetPageInfo(ref string HelpFile, ref int HelpContext)
        {
            throw new NotImplementedException();
        }

        public void Apply()
        {
            throw new NotImplementedException();
        }

        public bool Dirty
        {
            get
            {
                return isDirty;
            }
        }

        [DispId(captionDisplayId)]
        public string PageCaption
        {
            get
            {
                return "Q4 Desktop Settings";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Email = txtEmail.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();

            isDirty = true;
        }
    }
}
