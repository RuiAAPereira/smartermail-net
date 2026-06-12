
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AdminSetTwoFactorRecoveryRequest
{
    public string? Email { get; init; }
}
