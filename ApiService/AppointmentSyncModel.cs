using System;
using System.Collections.Generic;

namespace OutlookToDesktop.ApiService
{
    /// <summary>
    /// Mapping this model to _AppointmentItem
    /// Need to investigate types in _AppointmentItem that are references to other models. (OLRecurrenceState, Links etc)
    /// </summary>
    public class AppointmentSyncModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Categories { get; set; }
        public string Companies { get; set; }
        public DateTime CreationTime { get; set; }
        public string Mileage { get; set; }
        public bool NoAging { get; set; }
        public string Subject { get; set; }
        public bool UnRead { get; set; }
        public bool AllDayEvent { get; set; }
        public int Durection { get; set; }
        public DateTime End { get; set; }
        public bool IsOnlineMeeting { get; set; }
        public bool IsRecurring { get; set; }
        public string Location { get; set; }
        public bool NetMeetingAutoStart { get; set; }
        public string NetMeetingOrganizerAlias { get; set; }
        public string NetMeetingServer { get; set; }
        public string OptionalAttendees { get; set; }
        public string Organizer { get; set; }
        public List<string> Recipients { get; set; }
        public int ReminderMinutesbeforeStart { get; set; }
        public bool ReminderOverrideDetault { get; set; }
        public bool ReminderPlaySound { get; set; }
        public bool ReminderSet { get; set; }
        public string ReminderSoundFile { get; set; }
        public DateTime ReplyTime { get; set; }
        public string RequiredAttendees { get; set; }
        public string Resources { get; set; }
        public bool ResponseRequested { get; set; }
        public DateTime Start { get; set; }
        public string NetMeetingDocPathName { get; set; }
        public string NetShowUrl { get; set; }

    }
}
