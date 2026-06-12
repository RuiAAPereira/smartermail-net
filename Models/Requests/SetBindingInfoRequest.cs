
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetBindingInfoRequest
{
    public SmarterMail.Net.Models.Enums.InterNetworkVersion IpType { get; init; }
    public string? IpAddress { get; init; }
    public string? HostName { get; init; }
    public string? Description { get; init; }
    public JsonElement? PortIDs { get; init; }
}
