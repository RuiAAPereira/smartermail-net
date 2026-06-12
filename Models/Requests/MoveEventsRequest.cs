
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MoveEventsRequest
{
    public string? OrigOwner { get; init; }
    public string? OrigCalendar { get; init; }
    public string? DestOwner { get; init; }
    public string? DestCalendar { get; init; }
}
