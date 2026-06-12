
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetSpamAssassinServerListResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
