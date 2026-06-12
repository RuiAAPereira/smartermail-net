
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SimpleWhitelistGetRequest
{
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
