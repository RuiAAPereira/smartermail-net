
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SaveScheduleAppointmentRequest
{
    public JsonElement? DateRange { get; init; }
    public JsonElement? Start { get; init; }
    public string? TypeId { get; init; }
    public string? Email { get; init; }
    public JsonElement? GuestEmails { get; init; }
    public string? Fullname { get; init; }
    public JsonElement? SchedulingFields { get; init; }
    public JsonElement? FilledFields { get; init; }
    public string? ZoneId { get; init; }
}
