
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record EditFileRequest
{
    public string? Password { get; init; }
    public bool Published { get; init; }
    public JsonElement? PublishedUntil { get; init; }
    public string? NewFilename { get; init; }
    public string? ShortLink { get; init; }
}
