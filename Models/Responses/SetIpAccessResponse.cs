
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record SetIpAccessResponse
{
    public JsonElement? IpAccessData { get; init; }
    public string? Address { get; init; }
    public SmarterMail.Net.Models.Enums.IPAccessDataType DataType { get; init; }
    public string? Description { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
