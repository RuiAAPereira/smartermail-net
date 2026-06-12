
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SimpleWhitelistSetRequest
{
    public JsonElement? Domains { get; init; }
    public JsonElement? Emails { get; init; }
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
