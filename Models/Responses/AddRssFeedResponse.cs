
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record AddRssFeedResponse
{
    public long Id { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
