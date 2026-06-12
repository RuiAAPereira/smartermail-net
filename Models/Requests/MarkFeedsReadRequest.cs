
#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

public record MarkFeedsReadRequest
{
    public List<long>? FeedIds { get; init; }
}
