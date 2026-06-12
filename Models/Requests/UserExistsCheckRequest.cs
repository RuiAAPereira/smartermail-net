
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UserExistsCheckRequest
{
    public string? Email { get; init; }
}
