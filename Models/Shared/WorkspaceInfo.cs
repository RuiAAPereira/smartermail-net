// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "workspace" sub-object returned by workspace endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

using System;
using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record WorkspaceInfo
{
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
    public JsonElement? MeetingFolder { get; init; }
    public string? Name { get; init; }
    public string? Path { get; init; }
    public long Size { get; init; }
    public string? Version { get; init; }
    public JsonElement? SubFolders { get; init; }
    public long Count { get; init; }
    public JsonElement? Files { get; init; }
    public string? FileName { get; init; }
    public string? Type { get; init; }
    public DateTime? DateAdded { get; init; }
    public bool Published { get; init; }
    public JsonElement? PublishedUntil { get; init; }
    public string? Password { get; init; }
    public string? PreviewImage { get; init; }
    public string? ShortLink { get; init; }
    public string? PublicDownloadLink { get; init; }
    public string? EncryptedIdString { get; init; }
    public string? FolderPath { get; init; }
    public bool AttachedFile { get; init; }
    public string? AttachedFileSourceType { get; init; }
    public string? AttachedFileSource { get; init; }
    public bool AttendeesCanStart { get; init; }
    public string? ScheduledStart { get; init; }
    public string? StartTzId { get; init; }
    public string? ScheduledEnd { get; init; }
    public string? EndTzId { get; init; }
    public int EndMeetingBehavior { get; init; }
    public bool Archived { get; init; }
    public bool HasLinkedAppointment { get; init; }
    public bool IsLinkedAppointmentDeleted { get; init; }
}
