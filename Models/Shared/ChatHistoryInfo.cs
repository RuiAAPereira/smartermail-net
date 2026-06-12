// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "chatHistory" sub-object returned by the chat history by user endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record ChatHistoryInfo
{
    public JsonElement? ChatHistoryItems { get; init; }
    public DateTime? Date { get; init; }
    public string? To { get; init; }
    public string? From { get; init; }
    public string? PreviewText { get; init; }
    public long ChatId { get; init; }
}
