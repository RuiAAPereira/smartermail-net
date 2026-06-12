
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record RefreshTokenResponse
{
    public bool IsImpersonating { get; init; }
    public bool CanViewPasswords { get; init; }
    public string? AccessToken { get; init; }
    public string? RefreshToken { get; init; }
    public JsonElement? AccessTokenExpiration { get; init; }
    public JsonElement? RefreshTokenExpiration { get; init; }
    public string? Username { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
