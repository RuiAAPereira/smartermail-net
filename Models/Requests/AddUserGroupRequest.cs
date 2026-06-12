
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AddUserGroupRequest
{
    public JsonElement? UserGroup { get; init; }
}
