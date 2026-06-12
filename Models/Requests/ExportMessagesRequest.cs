
#nullable enable

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Requests;

public record ExportMessagesRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    [JsonPropertyName("uID")]
    public List<long>? Uid { get; init; }
}
