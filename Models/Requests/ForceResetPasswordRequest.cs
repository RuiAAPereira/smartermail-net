
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ForceResetPasswordRequest
{
    public string? OldPassword { get; init; }
    public string? Username { get; init; }
    public string? HostName { get; init; }
    public bool IsSysAdmin { get; init; }
    public string? NewPassword { get; init; }
}
