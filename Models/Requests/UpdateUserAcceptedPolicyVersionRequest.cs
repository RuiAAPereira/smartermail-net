
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateUserAcceptedPolicyVersionRequest
{
    public string? Email { get; init; }
}
