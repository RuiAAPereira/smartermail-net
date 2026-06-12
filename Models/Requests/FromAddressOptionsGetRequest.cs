
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record FromAddressOptionsGetRequest
{
    public bool AllowUnicode { get; init; }
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
