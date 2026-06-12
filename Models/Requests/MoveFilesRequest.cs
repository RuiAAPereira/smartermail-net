
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MoveFilesRequest
{
    public string? NewFolder { get; init; }
    public JsonElement? FileIDs { get; init; }
}
