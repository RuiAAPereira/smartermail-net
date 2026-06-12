
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetSourcesResponse
{
    public JsonElement? Sources { get; init; }
    public long FolderId { get; init; }
    public string? Id { get; init; }
    public string? Name { get; init; }
    public string? Color { get; init; }
    public bool IsVisible { get; init; }
    public bool IsPrimary { get; init; }
    public bool IsSharedItem { get; init; }
    public string? Owner { get; init; }
    public SmarterMail.Net.Models.Enums.ShareAccess Permission { get; init; }
    public bool IsCalendar { get; init; }
    public bool IsTask { get; init; }
    public bool IsDomainResource { get; init; }
    public string? InternetCalendarLink { get; init; }
    public int InternetCalendarInterval { get; init; }
    public bool IsMapped { get; init; }
    public bool IsWebCalendar { get; init; }
    public string? SubscriptionUrl { get; init; }
    public string? WebcalLink { get; init; }
    public bool AllowWebcalSubscription { get; init; }
    public string? EmailAlias { get; init; }
}
