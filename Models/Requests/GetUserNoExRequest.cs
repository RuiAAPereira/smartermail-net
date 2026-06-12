
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetUserNoExRequest
{
    public string? Email { get; init; }
}
