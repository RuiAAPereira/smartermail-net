
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ImpersonateUserRequest
{
    public string? Email { get; init; }
}
