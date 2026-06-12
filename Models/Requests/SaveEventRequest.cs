
#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Requests;

public record SaveEventRequest
{
    public long Id { get; init; }
    public string? Uid { get; init; }
    public string? CalendarId { get; init; }
    public JsonElement? RecurrenceId { get; init; }
    public string? CalendarOwner { get; init; }
    public bool AllDay { get; init; }
    public EventDateTime? Start { get; init; }
    public EventDateTime? End { get; init; }
    public string? Subject { get; init; }
    public bool IsHtml { get; init; }
    public string? Description { get; init; }
    public bool IsPrivate { get; init; }
    public string? Location { get; init; }
    public int Availability { get; init; }
    public string? EmailNotification { get; init; }
    public bool EmailNotificationEnabled { get; init; }
    public int ReminderIndex { get; init; }
    public string? Reminder { get; init; }
    public bool IsOrganizer { get; init; }
    public string? OrganizerName { get; init; }
    public string? OrganizerEmail { get; init; }
    public System.Collections.Generic.IReadOnlyList<EventAttendee>? Attendees { get; init; }
    public System.Collections.Generic.IReadOnlyList<EventCategory>? Categories { get; init; }
    public JsonElement? Recurrence { get; init; }
    public int Type { get; init; }
    public long UntilCount { get; init; }
    public bool UntilCountEnabled { get; init; }
    public DateTime? UntilDate { get; init; }
    public bool UntilDateEnabled { get; init; }
    public int DailyInterval { get; init; }
    public int WeeklyInterval { get; init; }
    public JsonElement? WeeklyDays { get; init; }
    public bool IsWeekdaysOnly { get; init; }
    public int MonthlyInterval { get; init; }
    public bool MonthlySpecificDay { get; init; }
    public int MonthDay { get; init; }
    public int MonthlyPeriodIndex { get; init; }
    public int MonthlyPeriodDayIndex { get; init; }
    public int YearlyInterval { get; init; }
    public bool YearlySpecificDate { get; init; }
    public int YearlyMonthIndex { get; init; }
    public int YearlyDay { get; init; }
    public int YearlyPeriodIndex { get; init; }
    public string? ResourceId { get; init; }
    public string? ResourceName { get; init; }
    public SmarterMail.Net.Models.Enums.ShareAccess Permission { get; init; }
    public DateTime? AcceptedOnDate { get; init; }
    public DateTime? DeclinedOnDate { get; init; }
    public bool IsTentative { get; init; }
    public DateTime? LastModified { get; init; }
    public string? ReservedBy { get; init; }
    public System.Collections.Generic.IReadOnlyList<EventAttachedFile>? AttachedFiles { get; init; }
    public bool HasAttachments { get; init; }
    /// <summary>When set, binds files previously uploaded under this attachment GUID to the saved event.</summary>
    public string? AttachmentGuid { get; init; }
    public JsonElement? FirstInstanceStart { get; init; }
    public JsonElement? FirstInstanceEnd { get; init; }
    public string? MeetingUrl { get; init; }
    public bool DisallowCounters { get; init; }
    public bool AllowReplies { get; init; }
    public SmarterMail.Net.Models.Enums.MeetingStatus MeetingStatus { get; init; }
    public bool MeetingInviteSent { get; init; }
}
