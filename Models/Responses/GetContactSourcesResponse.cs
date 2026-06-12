#nullable enable

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Responses;

public record GetContactSourcesResponse
{
    public IReadOnlyList<ContactSourceInfo>? SharedLists { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}

public record ContactSourceInfo
{
    [JsonPropertyName("itemID")]
    public string? ItemId { get; init; }

    public string? OwnerUsername { get; init; }
    public bool IsPrimary { get; init; }
    public bool IsSharedItem { get; init; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("folderId")]
    public long FolderId { get; init; }
}
