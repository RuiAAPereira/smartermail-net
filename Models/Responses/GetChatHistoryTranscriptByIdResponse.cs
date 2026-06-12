
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetChatHistoryTranscriptByIdResponse
{
    public JsonElement? Result { get; init; }
    public string? From { get; init; }
    public DateTime? Date { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
