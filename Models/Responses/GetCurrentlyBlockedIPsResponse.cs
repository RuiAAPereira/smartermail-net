
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetCurrentlyBlockedIPsResponse
{
    public JsonElement? IpBlocks { get; init; }
    public long Count { get; init; }
    public string? Ip { get; init; }
    public string? IpLocation { get; init; }
    public SmarterMail.Net.Models.Enums.BlockTypes BlockType { get; init; }
    public SmarterMail.Net.Models.Enums.BlockActions BlockAction { get; init; }
    public string? RuleDescription { get; init; }
    public int SecondsLeftOnBlock { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
