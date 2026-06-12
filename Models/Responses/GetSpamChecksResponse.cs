
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetSpamChecksResponse
{
    public int Total { get; init; }
    public JsonElement? SpamChecks { get; init; }
    public string? Key { get; init; }
    public string? Id { get; init; }
    public SmarterMail.Net.Models.Enums.FilterType Type { get; init; }
    public string? Name { get; init; }
    public int WeightLow { get; init; }
    public int WeightHigh { get; init; }
    public bool Enabled { get; init; }
    public bool IncomingBlock { get; init; }
    public bool OutgoingBlock { get; init; }
    public bool AttentionNeeded { get; init; }
    public bool IsUribl { get; init; }
    public bool Licensed { get; init; }
    public bool Default { get; init; }
    public bool ScanFromHeader { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
