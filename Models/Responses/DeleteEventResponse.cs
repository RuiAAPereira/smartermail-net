
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record DeleteEventResponse
{
    public string? Owner { get; init; }
    public string? CalendarId { get; init; }
    public string? EventId { get; init; }
    public JsonElement? InstanceStart { get; init; }
}
