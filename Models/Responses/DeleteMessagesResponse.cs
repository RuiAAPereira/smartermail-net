
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record DeleteMessagesResponse
{
    public JsonElement? NewUIDs { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
