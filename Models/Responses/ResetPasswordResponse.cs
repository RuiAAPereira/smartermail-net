
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ResetPasswordResponse
{
    public string? Username { get; init; }
    public string? ErrorCode { get; init; }
    public string? ErrorData { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
