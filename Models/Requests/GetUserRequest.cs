
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetUserRequest
{
    public string? Email { get; init; }
}
