
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateUserCategorySettingsRequest
{
    public string? DefaultCategory { get; init; }
    public JsonElement? Categories { get; init; }
    public string? Name { get; init; }
    public int ColorIndex { get; init; }
}
