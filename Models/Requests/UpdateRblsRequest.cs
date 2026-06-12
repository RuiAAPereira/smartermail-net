
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateRblsRequest
{
    public JsonElement? ItemsToUpdate { get; init; }
    public SmarterMail.Net.Models.Enums.RblType Type { get; init; }
    public string? Id { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? LookupDomain { get; init; }
    public bool EnableFiltering { get; init; }
    public bool EnableIncomingSmtpBlocking { get; init; }
    public bool EnableOutgoingSmtpBlocking { get; init; }
    public JsonElement? SpamResultIndicators { get; init; }
    public string? Ip { get; init; }
    public int Weight { get; init; }
    public int AverageTime { get; init; }
    public int Timeouts { get; init; }
    public JsonElement? ItemsToRemove { get; init; }
}
