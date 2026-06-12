
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record SearchSubscribersResponse
{
    public int Total { get; init; }
    public JsonElement? Items { get; init; }
    public long Id { get; init; }
    public string? EmailAddress { get; init; }
    public DateTime? SubscriptionDate { get; init; }
    public long BounceCount { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
