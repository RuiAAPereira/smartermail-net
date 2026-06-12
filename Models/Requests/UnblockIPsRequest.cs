
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UnblockIPsRequest
{
    public JsonElement? IpBlocks { get; init; }
    public long Count { get; init; }
    public string? Ip { get; init; }
    public string? IpLocation { get; init; }
    public SmarterMail.Net.Models.Enums.BlockTypes BlockType { get; init; }
    public SmarterMail.Net.Models.Enums.BlockActions BlockAction { get; init; }
    public string? RuleDescription { get; init; }
    public int SecondsLeftOnBlock { get; init; }
}
