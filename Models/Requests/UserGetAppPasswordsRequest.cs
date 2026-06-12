
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UserGetAppPasswordsRequest
{
    public string? Email { get; init; }
}
