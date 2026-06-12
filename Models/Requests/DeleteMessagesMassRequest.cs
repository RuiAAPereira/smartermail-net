
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteMessagesMassRequest
{
    public JsonElement? Messages { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
}
