
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UserCheckTwoFactorCodeRequest
{
    public string? Email { get; init; }
}
