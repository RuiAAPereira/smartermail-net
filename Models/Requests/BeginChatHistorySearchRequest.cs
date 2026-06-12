
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record BeginChatHistorySearchRequest
{
    public JsonElement? SearchArgs { get; init; }
    public string? Domain { get; init; }
    public DateTime? EndDateUtc { get; init; }
    public string? From { get; init; }
    public DateTime? StartDateUtc { get; init; }
    public string? Text { get; init; }
    public string? To { get; init; }
    public bool SkipDateCheck { get; init; }
    public bool MatchTo { get; init; }
}
