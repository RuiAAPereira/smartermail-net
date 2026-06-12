
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetSchedulingAvailableTimeResponse
{
    public JsonElement? AvailableTimes { get; init; }
    public JsonElement? Start { get; init; }
}
