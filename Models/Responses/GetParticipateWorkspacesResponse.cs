// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetParticipateWorkspacesResponse
{
    public long Count { get; init; }
    public JsonElement? Workspaces { get; init; }
    public long Id { get; init; }
    public string? FullId { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public DateTime? CreatedUtc { get; init; }
    public DateTime? LastActiveUtc { get; init; }
    public bool IsPasswordProtected { get; init; }
    public string? Title { get; init; }
    public string? Description { get; init; }
    public string? PublicIdentifier { get; init; }
    public bool AllowGuestUsers { get; init; }
    public long BytesUsed { get; init; }
    public string? Creator { get; init; }
    public FolderInfo? MeetingFolder { get; init; }
    public bool AttendeesCanStart { get; init; }
    public string? ScheduledStart { get; init; }
    public string? StartTzId { get; init; }
    public string? ScheduledEnd { get; init; }
    public string? EndTzId { get; init; }
    public int EndMeetingBehavior { get; init; }
    public bool Archived { get; init; }
    public bool HasLinkedAppointment { get; init; }
    public bool IsLinkedAppointmentDeleted { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}