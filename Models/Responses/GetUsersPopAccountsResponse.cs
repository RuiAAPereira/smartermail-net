
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetUsersPopAccountsResponse
{
    public string? OauthCode { get; init; }
    public string? OauthAccount { get; init; }
    public string? OauthAccessToken { get; init; }
    public string? OauthRefreshToken { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
