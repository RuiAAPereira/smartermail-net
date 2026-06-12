
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record SimpleWhitelistGetResponse
{
    public JsonElement? Emails { get; init; }
    public JsonElement? Domains { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
