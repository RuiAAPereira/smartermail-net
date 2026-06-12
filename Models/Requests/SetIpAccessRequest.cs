
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetIpAccessRequest
{
    public JsonElement? IpAccessData { get; init; }
    public string? Address { get; init; }
    public SmarterMail.Net.Models.Enums.IPAccessDataType DataType { get; init; }
    public string? Description { get; init; }
    public JsonElement? ToAdd { get; init; }
    public JsonElement? ToRemove { get; init; }
}
