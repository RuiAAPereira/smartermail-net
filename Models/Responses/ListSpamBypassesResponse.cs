
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ListSpamBypassesResponse
{
    public long TotalCount { get; init; }
    public JsonElement? Items { get; init; }
    public string? Id { get; init; }
    public string? Ip { get; init; }
    public string? Description { get; init; }
    public bool BypassSpamChecks { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
