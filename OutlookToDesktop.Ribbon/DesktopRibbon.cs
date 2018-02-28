using OutlookToDesktop.ApiService;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace OutlookAddIn
{
    public partial class DesktopRibbon
    {
        private readonly string _captionTitle = "Q4 Desktop";
        private IAppointmentService _appointmentService;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            sndButton.Click += SndButton_Click;

            
            
        }

        private void SndButton_Click(object sender, RibbonControlEventArgs e)
        {
            var authenticationService = new AuthenticationService("https://develop.q4touch.com", Properties.Settings.Default.Email, Properties.Settings.Default.Password);
            _appointmentService = new AppointmentService(authenticationService);

            string message = "The appointment has been synced to Q4 Desktop";

            MessageBox.Show(message, _captionTitle);
        }
    }
}
