
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetContentFilterGroups_UserRequest
{
    public JsonElement? ContentFilterGroups { get; init; }
    public JsonElement? ToAdd { get; init; }
    public JsonElement? ToRemove { get; init; }
}
