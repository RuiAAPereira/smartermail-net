
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record CheckCaptchaRequest
{
    public string? CaptchaText { get; init; }
}
