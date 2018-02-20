using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace OutlookAddIn
{
    public partial class DesktopRibbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            sndButton.Click += SndButton_Click;    
        }

        private void SndButton_Click(object sender, RibbonControlEventArgs e)
        {
            string message = "The appointment has been synced to Q4 Desktop";
            string caption = "Q4 Desktop";

            MessageBox.Show(message, caption);
        }
    }
}
