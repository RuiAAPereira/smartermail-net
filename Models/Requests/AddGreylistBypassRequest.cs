
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AddGreylistBypassRequest
{
    public JsonElement? Filter { get; init; }
    public string? CountryCode { get; init; }
    public string? IpAddress { get; init; }
    public string? Description { get; init; }
    public SmarterMail.Net.Models.Enums.GreylistFilterType FilterType { get; init; }
    public string? Id { get; init; }
}
