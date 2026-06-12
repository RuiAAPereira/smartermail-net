// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetOccurrenceDetailsResponse
{
    public OccurrenceDetailsInfo? Details { get; init; }
    public JsonElement? End { get; init; }
    public string? Subject { get; init; }
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
    public JsonElement? Attendees { get; init; }
    public string? Name { get; init; }
    public string? Email { get; init; }
    public int Status { get; init; }
    public bool Conflict { get; init; }
    public JsonElement? Nonavail { get; init; }
    public bool IsResource { get; init; }
    public JsonElement? Categories { get; init; }
    public bool Master { get; init; }
    public RecurrenceInfo? Recurrence { get; init; }
    public string? ResourceId { get; init; }
    public string? ResourceName { get; init; }
    public SmarterMail.Net.Models.Enums.ShareAccess Permission { get; init; }
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
    public SmarterMail.Net.Models.Enums.MeetingStatus MeetingStatus { get; init; }
    public bool MeetingInviteSent { get; init; }
    public string? ParticipantStatus { get; init; }
    public JsonElement? Proposals { get; init; }
}
