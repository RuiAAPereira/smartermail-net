namespace SmarterMail.Net.Authentication.Internal;

internal sealed record TokenResponse
{
    public string? AccessToken { get; init; }
    public string? RefreshToken { get; init; }
    public DateTime? AccessTokenExpiration { get; init; }
    public DateTime? RefreshTokenExpiration { get; init; }
    public bool Success { get; init; }
}
