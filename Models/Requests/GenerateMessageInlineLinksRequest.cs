
#nullable enable

using System.Collections.Generic;
using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GenerateMessageInlineLinksRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public long Uid { get; init; }
    public List<double>? PartIds { get; init; }
}
