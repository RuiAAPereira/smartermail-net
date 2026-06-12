// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "searchResults" sub-object returned by the chat history search results endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record ChatSearchResultsInfo
{
    public int PercentProgress { get; init; }
    public JsonElement? Results { get; init; }
    public DateTime? Date { get; init; }
    public string? To { get; init; }
    public string? From { get; init; }
    public string? PreviewText { get; init; }
    public long ChatId { get; init; }
    public int StartIndex { get; init; }
}
