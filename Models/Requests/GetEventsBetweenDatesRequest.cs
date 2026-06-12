
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetEventsBetweenDatesRequest
{
    public DateTime? StartDate { get; init; }
    public DateTime? EndDate { get; init; }
    public JsonElement? FilterFlags { get; init; }
}
