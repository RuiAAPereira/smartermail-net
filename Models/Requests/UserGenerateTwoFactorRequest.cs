
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UserGenerateTwoFactorRequest
{
    public string? Email { get; init; }
}
