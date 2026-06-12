
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record RefreshTokenRequest
{
    public string? Token { get; init; }
}
