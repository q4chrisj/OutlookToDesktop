using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using OutlookToDesktop.ApiService;
using System.Collections.Generic;
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
            _appointmentService = new AppointmentService(authenticationService, "https://develop.q4touch.com");

            var context = Context as Inspector;
            var appointment = context.CurrentItem as AppointmentItem;

            var desktopAppointment = new AppointmentModel
            {
                Body = appointment.Body,
                Title = appointment.Subject,
                AllDayEvent = appointment.AllDayEvent,
                Categories = appointment.Categories,
                Companies = appointment.Companies,
                CreationTime = appointment.CreationTime,
                Duration = appointment.Duration,
                End = appointment.End,
                IsOnlineMeeting = appointment.IsOnlineMeeting,
                IsRecurring = appointment.IsRecurring,
                Location = appointment.Location,
                Mileage = appointment.Mileage,
                NetMeetingAutoStart = appointment.NetMeetingAutoStart,
                NetMeetingDocPathName = appointment.NetMeetingDocPathName,
                NetMeetingOrganizerAlias = appointment.NetMeetingOrganizerAlias,
                NetMeetingServer = appointment.NetMeetingServer,
                NetShowUrl = appointment.NetShowURL,
                NoAging = appointment.NoAging,
                OptionalAttendees = appointment.OptionalAttendees,
                Organizer = appointment.Organizer,
                ReminderMinutesbeforeStart = appointment.ReminderMinutesBeforeStart,
                ReminderOverrideDetault = appointment.ReminderOverrideDefault,
                ReminderPlaySound = appointment.ReminderPlaySound,
                ReminderSet = appointment.ReminderSet,
                ReminderSoundFile = appointment.ReminderSoundFile,
                ReplyTime = appointment.ReplyTime,
                RequiredAttendees = appointment.RequiredAttendees,
                Resources = appointment.Resources,
                ResponseRequested = appointment.ResponseRequested,
                Start = appointment.Start,
                Subject = appointment.Subject,
                UnRead = appointment.UnRead
            };

            desktopAppointment.Recipients = new List<RecipientModel>();
            foreach (Recipient recipient in appointment.Recipients)
            {
                if (recipient != null)
                {
                    desktopAppointment.Recipients.Add(new RecipientModel
                    {
                        Name = recipient.Name,
                        Email = recipient.Address
                    });
                }
            }

            var appointmentSyncModel = new AppointmentSyncModel();
            appointmentSyncModel.Data = desktopAppointment;

            _appointmentService.SyncAppointmentAsync(appointmentSyncModel);

            string message = "The appointment has been synced to Q4 Desktop";

            MessageBox.Show(message, _captionTitle);
        }
    }
}
