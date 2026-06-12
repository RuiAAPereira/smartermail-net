
#nullable enable

namespace SmarterMail.Net.Models.Requests;

public record AddOrEditInternetCalendarRequest
{
    public string? Id { get; init; }
    public string? Name { get; init; }
    public string? Url { get; init; }
    public int Interval { get; init; }
    public bool IntervalOverride { get; init; }
}
