
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetDkimSettingsRequest
{
    public string? CanonicalizationBody { get; init; }
    public string? CanonicalizationHeader { get; init; }
    public string? FieldOption { get; init; }
    public JsonElement? Fields { get; init; }
}
