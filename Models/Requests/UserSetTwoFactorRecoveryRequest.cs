
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UserSetTwoFactorRecoveryRequest
{
    public string? Email { get; init; }
}
