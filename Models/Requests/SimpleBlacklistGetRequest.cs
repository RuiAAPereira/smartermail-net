
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SimpleBlacklistGetRequest
{
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
