
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record CheckPopMigrationSizeRequest
{
    public string? OauthCode { get; init; }
    public string? OauthAccount { get; init; }
    public string? OauthAccessToken { get; init; }
    public string? OauthRefreshToken { get; init; }
}
