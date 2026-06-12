
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ResetPasswordRequestRequest
{
    public string? Id { get; init; }
    public string? NewPassword { get; init; }
}
