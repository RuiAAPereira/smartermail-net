
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateCustomRulesRequest
{
    public JsonElement? ItemsToUpdate { get; init; }
    public SmarterMail.Net.Models.Enums.CustomRuleMatchTypes MatchType { get; init; }
    public SmarterMail.Net.Models.Enums.CustomRuleSourceTypes Source { get; init; }
    public int Weight { get; init; }
    public string? Id { get; init; }
    public string? Name { get; init; }
    public string? RuleArgument { get; init; }
    public bool EnableFiltering { get; init; }
    public bool EnableOutgoingSmtpBlocking { get; init; }
    public bool MatchMultiple { get; init; }
    public JsonElement? RuleItems { get; init; }
    public JsonElement? ItemsToRemove { get; init; }
}
