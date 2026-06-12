
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SimpleCategoryManageApiPostRequest
{
    public JsonElement? Categories { get; init; }
    public string? Name { get; init; }
    public int ColorIndex { get; init; }
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
