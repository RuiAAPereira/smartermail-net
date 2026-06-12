
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateUserGroupRequest
{
    public JsonElement? UserGroup { get; init; }
}
