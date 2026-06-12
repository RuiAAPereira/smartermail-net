
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record RetrieveLoginTokenRequest
{
    public string? Username { get; init; }
    public string? Domain { get; init; }
}
