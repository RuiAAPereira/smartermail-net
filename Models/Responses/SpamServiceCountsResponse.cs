
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record SpamServiceCountsResponse
{
    public long SpamCheckCount { get; init; }
    public long RblCount { get; init; }
    public long UriblCount { get; init; }
    public long BypassGatewayCount { get; init; }
    public long GreylistFilterCount { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
