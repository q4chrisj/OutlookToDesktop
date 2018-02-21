using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace OutlookAddIn
{
    /// <summary>
    /// 1. When the control loads, we should check with Q4 Desktop to see if this appointment has been synced already (based on some kind of id)
    ///   a. If the appointment has been synced, set isSynced = true
    ///   b. If the appointment has not been synced, set isSynced = false
    /// 2. If isSynced = true, then override the send button with a synced button
    /// 3. If isSynced = false, then leave the UI as is.
    /// </summary>
    public partial class DesktopRibbon
    {
        private readonly string _captionTitle = "Q4 Desktop";
        private bool _isSynced = false;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            btnRemove.Click += BtnRemove_Click;
            sndButton.Click += SndButton_Click;

            LoadRibbon();
        }

        private void LoadRibbon()
        {
            btnRemove.Enabled = _isSynced ? true : false;
            sndButton.Enabled = _isSynced ? false : true;
        }

        private void BtnRemove_Click(object sender, RibbonControlEventArgs e)
        {
            string message = "The appointment has been removed from Q4 Desktop";
            _isSynced = false;

            LoadRibbon();
            MessageBox.Show(message, _captionTitle);
        }

        private void SndButton_Click(object sender, RibbonControlEventArgs e)
        {
            string message = "The appointment has been synced to Q4 Desktop";
            _isSynced = true;
            LoadRibbon();

            MessageBox.Show(message, _captionTitle);
        }
    }
}
