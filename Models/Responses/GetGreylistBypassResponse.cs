
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetGreylistBypassResponse
{
    public JsonElement? Filters { get; init; }
    public string? CountryCode { get; init; }
    public string? IpAddress { get; init; }
    public string? Description { get; init; }
    public SmarterMail.Net.Models.Enums.GreylistFilterType FilterType { get; init; }
    public string? Id { get; init; }
    public long TotalCount { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
