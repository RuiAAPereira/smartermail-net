
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record RetrieveLoginTokenResponse
{
    public string? AutoLoginToken { get; init; }
    public string? AutoLoginUrl { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
