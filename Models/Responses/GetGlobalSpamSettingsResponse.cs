// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetGlobalSpamSettingsResponse
{
    public GlobalSpamSettingsInfo? Settings { get; init; }
    public JsonElement? Cyren { get; init; }
    public JsonElement? CyrenIp { get; init; }
    public JsonElement? Declude { get; init; }
    public JsonElement? Dkim { get; init; }
    public JsonElement? Greylisting { get; init; }
    public JsonElement? MessageSniffer { get; init; }
    public JsonElement? ReverseDns { get; init; }
    public JsonElement? NullSender { get; init; }
    public JsonElement? SpamAssassin { get; init; }
    public JsonElement? RemoteSpamAssassin { get; init; }
    public JsonElement? RemoteRspamd { get; init; }
    public JsonElement? Spf { get; init; }
    public JsonElement? HoneyPot { get; init; }
    public JsonElement? Dmarc { get; init; }
    public JsonElement? PrivateSuffixList { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}