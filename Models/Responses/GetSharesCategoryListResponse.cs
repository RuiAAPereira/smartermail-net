
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetSharesCategoryListResponse
{
    public JsonElement? SharedCategorySettings { get; init; }
    public string? DefaultCategory { get; init; }
    public JsonElement? Categories { get; init; }
    public string? Name { get; init; }
    public int ColorIndex { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
