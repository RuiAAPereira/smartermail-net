
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record SearchAutoCompleteListResponse
{
    public JsonElement? EmailData { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
