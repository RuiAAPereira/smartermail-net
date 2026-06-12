
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateSpamBypassesRequest
{
    public JsonElement? ItemsToUpdate { get; init; }
    public string? Id { get; init; }
    public string? Ip { get; init; }
    public string? Description { get; init; }
    public bool BypassSpamChecks { get; init; }
    public JsonElement? ItemsToRemove { get; init; }
}
