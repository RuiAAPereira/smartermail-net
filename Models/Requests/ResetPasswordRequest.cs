
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ResetPasswordRequest
{
    public string? Id { get; init; }
    public string? NewPassword { get; init; }
}
