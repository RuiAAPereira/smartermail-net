
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record RefreshRssFeedRequest
{
    public JsonElement? Ids { get; init; }
}
