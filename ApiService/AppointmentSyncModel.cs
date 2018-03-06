using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OutlookToDesktop.ApiService
{
    public class AppointmentSyncModel
    {
        [JsonProperty("profile")]
        public ProfileModel Profile { get; set; }

        [JsonProperty("data")]
        public AppointmentModel Data { get; set; }     
    }

    /// <summary>
    /// Mapping this model to _AppointmentItem
    /// Need to investigate types in _AppointmentItem that are references to other models. (OLRecurrenceState, Links etc)
    /// </summary>
    public class AppointmentModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("categories")]
        public string Categories { get; set; }

        [JsonProperty("companies")]
        public string Companies { get; set; }

        [JsonProperty("creationTime")]
        public DateTime CreationTime { get; set; }

        [JsonProperty("mileage")]
        public string Mileage { get; set; }

        [JsonProperty("noAging")]
        public bool NoAging { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("unRead")]
        public bool UnRead { get; set; }

        [JsonProperty("allDayEvent")]
        public bool AllDayEvent { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("end")]
        public DateTime End { get; set; }

        [JsonProperty("isOnlineMeeting")]
        public bool IsOnlineMeeting { get; set; }

        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("netMettingAutoStart")]
        public bool NetMeetingAutoStart { get; set; }

        [JsonProperty("netMeetingOrganizerAlias")]
        public string NetMeetingOrganizerAlias { get; set; }

        [JsonProperty("netMeetingServer")]
        public string NetMeetingServer { get; set; }

        [JsonProperty("optionalAttendees")]
        public string OptionalAttendees { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("recipients")]
        public List<string> Recipients { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int ReminderMinutesbeforeStart { get; set; }

        [JsonProperty("reminderOverrideDefault")]
        public bool ReminderOverrideDetault { get; set; }

        [JsonProperty("reminderPlaySound")]
        public bool ReminderPlaySound { get; set; }

        [JsonProperty("reminderSet")]
        public bool ReminderSet { get; set; }

        [JsonProperty("reminderSoundFile")]
        public string ReminderSoundFile { get; set; }

        [JsonProperty("replyTime")]
        public DateTime ReplyTime { get; set; }

        [JsonProperty("requiredAttendees")]
        public string RequiredAttendees { get; set; }

        [JsonProperty("resources")]
        public string Resources { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("start")]
        public DateTime Start { get; set; }

        [JsonProperty("netMeetingDocPathName")]
        public string NetMeetingDocPathName { get; set; }

        [JsonProperty("netShowUrl")]
        public string NetShowUrl { get; set; }
    }
}
