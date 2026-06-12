// Calendar-specific projection of MessageDataInfo.
// Populated only when the message is a calendar invitation/response.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record CalendarMessageInfo
{
    public string? CalendarId { get; init; }
    public string? CalendarOwner { get; init; }
    public string? Comment { get; init; }
    public string? Description { get; init; }
    public string? EventId { get; init; }
    public string? Location { get; init; }
    public string? Reminder { get; init; }
    public bool Conflict { get; init; }
    public bool IsOrganizer { get; init; }
    public bool IsAllDay { get; init; }
    public bool IsCancel { get; init; }
    public bool IsReply { get; init; }
    public bool MeetingCancelled { get; init; }
    public bool NewerVersionFound { get; init; }
    public bool OlderVersionFound { get; init; }
    public bool Master { get; init; }
    public bool ShowAccept { get; init; }
    public bool ShowCheckAvailability { get; init; }
    public bool ShowDecline { get; init; }
    public bool ShowDelete { get; init; }
    public bool ShowDetails { get; init; }
}
