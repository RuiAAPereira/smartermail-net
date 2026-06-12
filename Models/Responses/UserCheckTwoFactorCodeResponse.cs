
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record UserCheckTwoFactorCodeResponse
{
    public bool Result { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
