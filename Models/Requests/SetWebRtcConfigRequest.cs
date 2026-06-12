
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetWebRtcConfigRequest
{
    public JsonElement? StunTurnServers { get; init; }
}
