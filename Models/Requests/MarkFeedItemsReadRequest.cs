
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MarkFeedItemsReadRequest
{
    public long FeedId { get; init; }
}
