
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AuthenticateUserRequest
{
    public string? Username { get; init; }
    public string? Password { get; init; }
    public bool TeamWorkspace { get; init; }
    public string? TwoFactorCode { get; init; }
    public string? TwoFactorSetupGuid { get; init; }
    public bool RetrieveAutoLoginToken { get; init; }
    public string? AutoLoginToken { get; init; }
}
