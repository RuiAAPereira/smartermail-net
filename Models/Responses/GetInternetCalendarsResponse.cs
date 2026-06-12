
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetInternetCalendarsResponse
{
    public JsonElement? InternetCalendars { get; init; }
    public string? Id { get; init; }
    public string? Name { get; init; }
    public string? Url { get; init; }
    public int Interval { get; init; }
    public bool IntervalOverride { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
