
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetUserGroupCollectionRequest
{
    public JsonElement? UserGroups { get; init; }
}
