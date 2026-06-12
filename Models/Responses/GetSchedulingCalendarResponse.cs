
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetSchedulingCalendarResponse
{
    public string? PageDescription { get; init; }
    public string? BackgroundColor { get; init; }
    public string? AppointmentTitleColor { get; init; }
    public string? DisplayNameColor { get; init; }
    public string? AvatarUrl { get; init; }
    public string? DisplayName { get; init; }
    public SmarterMail.Net.Models.Enums.DayOfWeek FirstDayOfWeek { get; init; }
    public JsonElement? Sunday { get; init; }
    public JsonElement? Monday { get; init; }
    public JsonElement? Tuesday { get; init; }
    public JsonElement? Wednesday { get; init; }
    public JsonElement? Thursday { get; init; }
    public JsonElement? Friday { get; init; }
    public JsonElement? Saturday { get; init; }
    public SmarterMail.Net.Models.Enums.BookingHorizonLimit BookingHorizonLimit { get; init; }
    public JsonElement? AppointmentTypes { get; init; }
    public JsonElement? SchedulingFields { get; init; }
}
