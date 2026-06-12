
#nullable enable

namespace SmarterMail.Net.Models.Requests;

public record EditUserCalendarRequest
{
    public SmarterMail.Net.Models.Enums.ShareType Type { get; init; }
    public string? Id { get; init; }
    public string? FriendlyName { get; init; }
    public string? CalendarViewColor { get; init; }
    public bool ShowInCalendar { get; init; }
    public bool ShowInTasks { get; init; }
    public bool ShowInContacts { get; init; }
    public bool ShowInNotes { get; init; }
    public bool IsPrimary { get; init; }
    public bool AllowWebcalSubscription { get; init; }
}
