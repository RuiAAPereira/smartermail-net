// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "attachedMessage" sub-object inside task responses.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record AttachedMessageInfo
{
    public string? Subject { get; init; }
    public string? To { get; init; }
    public string? From { get; init; }
    public DateTime? Date { get; init; }
    public long Uid { get; init; }
    public string? Owner { get; init; }
    public bool ImagesBlocked { get; init; }
    public bool BypassRemoteContent { get; init; }
    public bool IsCalendarMessage { get; init; }
    public JsonElement? BlockedContentOrigins { get; init; }
}
