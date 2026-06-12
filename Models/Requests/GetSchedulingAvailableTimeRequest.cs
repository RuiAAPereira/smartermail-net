
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetSchedulingAvailableTimeRequest
{
    public string? Date { get; init; }
    public string? ZoneId { get; init; }
    public int Between { get; init; }
}
