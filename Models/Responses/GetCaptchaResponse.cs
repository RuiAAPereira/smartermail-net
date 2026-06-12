
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetCaptchaResponse
{
    public JsonElement? CaptchaImage { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
