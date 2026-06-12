
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AdminSetTwoFactorRequest
{
    public string? Email { get; init; }
}
