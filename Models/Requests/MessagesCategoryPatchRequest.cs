
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MessagesCategoryPatchRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public JsonElement? Uid { get; init; }
    public bool ClearCategories { get; init; }
    public bool RemoveCategories { get; init; }
    public JsonElement? Categories { get; init; }
}
