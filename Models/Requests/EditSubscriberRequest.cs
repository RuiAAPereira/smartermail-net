
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record EditSubscriberRequest
{
    public string? EmailAddress { get; init; }
    public JsonElement? FieldValues { get; init; }
    public string? Name { get; init; }
    public JsonElement? SubscribedLists { get; init; }
    public JsonElement? SubscribedDigests { get; init; }
}
