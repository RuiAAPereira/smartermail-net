
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetSubscriberDetailsResponse
{
    public string? EmailAddress { get; init; }
    public JsonElement? FieldValues { get; init; }
    public string? Name { get; init; }
    public JsonElement? SubscribedLists { get; init; }
    public JsonElement? SubscribedDigests { get; init; }
    public string? BounceAddress { get; init; }
    public long BounceCount { get; init; }
    public JsonElement? Bounces { get; init; }
    public JsonElement? MessageLog { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
