
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record SearchPostersResponse
{
    public int Total { get; init; }
    public JsonElement? Items { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
