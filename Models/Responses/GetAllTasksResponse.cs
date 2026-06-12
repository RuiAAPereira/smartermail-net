// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetAllTasksResponse
{
    public long TotalCount { get; init; }
    public JsonElement? Results { get; init; }
    public string? Id { get; init; }
    public string? SourceId { get; init; }
    public string? SourceOwner { get; init; }
    public string? SourceName { get; init; }
    public string? AttachedMessageId { get; init; }
    public JsonElement? Start { get; init; }
    public JsonElement? Due { get; init; }
    public JsonElement? Reminder { get; init; }
    public bool UseDateTime { get; init; }
    public bool ReminderSet { get; init; }
    public int Priority { get; init; }
    public int Status { get; init; }
    public int PercentComplete { get; init; }
    public string? Subject { get; init; }
    public string? Description { get; init; }
    public JsonElement? Categories { get; init; }
    public string? Name { get; init; }
    public bool Master { get; init; }
    public JsonElement? AttachedFiles { get; init; }
    public string? Filename { get; init; }
    public string? ContentType { get; init; }
    public string? ContentId { get; init; }
    public bool IsInline { get; init; }
    public long Size { get; init; }
    public DateTime? CreatedDateUtc { get; init; }
    public string? FileReference { get; init; }
    public string? AlternateId { get; init; }
    public AttachedMessageInfo? AttachedMessage { get; init; }
    public string? UserTimeZone { get; init; }
    public long ItemId { get; init; }
    public bool IsDelegatedByOwner { get; init; }
    public string? AssignedName { get; init; }
    public RecurrenceInfo? Recurrence { get; init; }
    public bool IsPrivate { get; init; }
    public SmarterMail.Net.Models.Enums.ShareAccess Permission { get; init; }
    public string? AttachmentGuid { get; init; }
}
