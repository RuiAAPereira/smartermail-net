
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record UntrustSendersResponse
{
    public JsonElement? Results { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
