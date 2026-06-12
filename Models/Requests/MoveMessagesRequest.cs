
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MoveMessagesRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public string? DestinationOwnerEmailAddress { get; init; }
    public string? DestinationFolder { get; init; }
    public JsonElement? UID { get; init; }
}
