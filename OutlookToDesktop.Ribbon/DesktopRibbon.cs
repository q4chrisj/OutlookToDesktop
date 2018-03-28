using log4net;
using log4net.Config;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using OutlookToDesktop.ApiService;
using System.Reflection;
using System.Windows.Forms;

namespace OutlookAddIn
{
    public partial class DesktopRibbon
    {
        private readonly string _captionTitle = "Q4 Desktop";
        private readonly string _desktopDomain = "https://develop.q4touch.com";

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            XmlConfigurator.Configure();
            sndButton.Click += SndButton_Click;
        }

        private void SndButton_Click(object sender, RibbonControlEventArgs e)
        {
            ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            IAuthenticationService authenticationService = new AuthenticationService(_desktopDomain, Properties.Settings.Default.Email, Properties.Settings.Default.Password);
            IAppointmentService appointmentService = new AppointmentService(authenticationService, _desktopDomain, Log);

            var context = Context as Inspector;
            var appointment = context.CurrentItem as AppointmentItem;
            
            var appointmentSyncModelFactory = new AppointmentSyncModelFactory();
            var appointmentSyncModel = appointmentSyncModelFactory.Create(appointment);
            
            appointmentService.SyncAppointmentAsync(appointmentSyncModel);

            string message = "The appointment has been synced to Q4 Desktop";

            MessageBox.Show(message, _captionTitle);
        }
    }
}
