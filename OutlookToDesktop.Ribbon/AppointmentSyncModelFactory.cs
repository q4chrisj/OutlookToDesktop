using Microsoft.Office.Interop.Outlook;
using OutlookToDesktop.ApiService;
using System.Collections.Generic;

namespace OutlookAddIn
{
    public class AppointmentSyncModelFactory
    {
        public AppointmentSyncModel Create(AppointmentItem appointmentItem)
        {
            var desktopAppointment = new AppointmentModel
            {
                Body = appointmentItem.Body,
                Title = appointmentItem.Subject,
                AllDayEvent = appointmentItem.AllDayEvent,
                Categories = appointmentItem.Categories,
                Companies = appointmentItem.Companies,
                CreationTime = appointmentItem.CreationTime,
                Duration = appointmentItem.Duration,
                End = appointmentItem.End,
                IsOnlineMeeting = appointmentItem.IsOnlineMeeting,
                IsRecurring = appointmentItem.IsRecurring,
                Location = appointmentItem.Location,
                Mileage = appointmentItem.Mileage,
                NetMeetingAutoStart = appointmentItem.NetMeetingAutoStart,
                NetMeetingDocPathName = appointmentItem.NetMeetingDocPathName,
                NetMeetingOrganizerAlias = appointmentItem.NetMeetingOrganizerAlias,
                NetMeetingServer = appointmentItem.NetMeetingServer,
                NetShowUrl = appointmentItem.NetShowURL,
                NoAging = appointmentItem.NoAging,
                OptionalAttendees = appointmentItem.OptionalAttendees,
                Organizer = appointmentItem.Organizer,
                ReminderMinutesbeforeStart = appointmentItem.ReminderMinutesBeforeStart,
                ReminderOverrideDetault = appointmentItem.ReminderOverrideDefault,
                ReminderPlaySound = appointmentItem.ReminderPlaySound,
                ReminderSet = appointmentItem.ReminderSet,
                ReminderSoundFile = appointmentItem.ReminderSoundFile,
                ReplyTime = appointmentItem.ReplyTime,
                RequiredAttendees = appointmentItem.RequiredAttendees,
                Resources = appointmentItem.Resources,
                ResponseRequested = appointmentItem.ResponseRequested,
                Start = appointmentItem.Start,
                Subject = appointmentItem.Subject,
                UnRead = appointmentItem.UnRead
            };

            desktopAppointment.Recipients = new List<RecipientModel>();
            foreach (Recipient recipient in appointmentItem.Recipients)
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

            return appointmentSyncModel;
        }
    }
}
