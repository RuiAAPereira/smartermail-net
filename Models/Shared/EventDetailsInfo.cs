// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail /calendar/get-event-details response wraps all event content
// in a nested "details" object. This record represents that inner object.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record EventDetailsInfo
{
    public long Id { get; init; }
    public string? Uid { get; init; }
    public string? CalendarId { get; init; }
    public JsonElement? RecurrenceId { get; init; }
    public string? CalendarOwner { get; init; }
    public bool AllDay { get; init; }
    public JsonElement? Start { get; init; }
    public JsonElement? End { get; init; }
    public string? Subject { get; init; }
    public string? Description { get; init; }
    public bool IsHtml { get; init; }
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
    public JsonElement? Attendees { get; init; }
    public string? Name { get; init; }
    public string? Email { get; init; }
    public int Status { get; init; }
    public bool Conflict { get; init; }
    public JsonElement? Nonavail { get; init; }
    public bool IsResource { get; init; }
    public JsonElement? Categories { get; init; }
    public bool Master { get; init; }
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
    public ShareAccess Permission { get; init; }
    public DateTime? AcceptedOnDate { get; init; }
    public DateTime? DeclinedOnDate { get; init; }
    public bool IsTentative { get; init; }
    public DateTime? LastModified { get; init; }
    public string? ReservedBy { get; init; }
    public JsonElement? AttachedFiles { get; init; }
    public string? Filename { get; init; }
    public string? ContentType { get; init; }
    public string? ContentId { get; init; }
    public bool IsInline { get; init; }
    public long Size { get; init; }
    public DateTime? CreatedDateUtc { get; init; }
    public string? FileReference { get; init; }
    public string? AlternateId { get; init; }
    public bool HasAttachments { get; init; }
    public JsonElement? FirstInstanceStart { get; init; }
    public JsonElement? FirstInstanceEnd { get; init; }
    public string? MeetingUrl { get; init; }
    public bool DisallowCounters { get; init; }
    public bool AllowReplies { get; init; }
    public MeetingStatus MeetingStatus { get; init; }
    public bool MeetingInviteSent { get; init; }
    public string? ParticipantStatus { get; init; }
    public JsonElement? Proposals { get; init; }
}
