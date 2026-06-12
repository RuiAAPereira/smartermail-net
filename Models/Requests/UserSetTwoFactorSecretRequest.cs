
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UserSetTwoFactorSecretRequest
{
    public string? Email { get; init; }
}
