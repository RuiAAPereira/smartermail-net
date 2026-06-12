// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record AuthenticateUserResponse
{
    public string? EmailAddress { get; init; }
    public bool ChangePasswordNeeded { get; init; }
    public bool PasswordExpired { get; init; }
    public bool DisplayWelcomeWizard { get; init; }
    public bool IsAdmin { get; init; }
    public bool IsDomainAdmin { get; init; }
    public bool IsLicensed { get; init; }
    public bool IsClusterAdmin { get; init; }
    public string? AutoLoginToken { get; init; }
    public string? AutoLoginUrl { get; init; }
    public string? LocaleId { get; init; }
    public PasswordRequirementsInfo? Requirements { get; init; }
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