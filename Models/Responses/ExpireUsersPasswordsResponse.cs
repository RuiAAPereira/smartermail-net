
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ExpireUsersPasswordsResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
