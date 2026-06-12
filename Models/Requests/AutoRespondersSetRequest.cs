
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AutoRespondersSetRequest
{
    public JsonElement? AutoResponderSettings { get; init; }
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
