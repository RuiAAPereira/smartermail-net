
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record HoneyPotListResponse
{
    public JsonElement? Entries { get; init; }
    public DateTime? DateAdded { get; init; }
    public JsonElement? Ip { get; init; }
    public string? HoneyPotAddress { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
