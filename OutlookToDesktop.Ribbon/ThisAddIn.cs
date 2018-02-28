﻿using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddIn
{
    public partial class ThisAddIn
    {
        
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Outlook.Application outlook = Globals.ThisAddIn.Application;
            outlook.OptionsPagesAdd += Outlook_OptionsPagesAdd;

            //var authenticationService = new AuthenticationService("http://develop.q4touch.com");
            //var task = authenticationService.Authenticate(Properties.Settings.Default.Email, Properties.Settings.Default.Password);
            //var token = task.GetAwaiter().GetResult();
        }

        private void Outlook_OptionsPagesAdd(Outlook.PropertyPages Pages)
        {
            Pages.Add(new OptionsPage(), "Q4 Desktop Settings");
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
