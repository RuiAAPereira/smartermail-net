#nullable enable

using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Requests;

public record GetRawMessageRequest
{
    public string? Folder { get; init; }
    [JsonPropertyName("UID")]
    public long Uid { get; init; }
    public string? OwnerEmailAddress { get; init; }
}
