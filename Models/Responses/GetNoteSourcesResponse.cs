#nullable enable

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for <c>GET /api/v1/notes/sources</c>. The live body wraps sources in "sharedLists".</summary>
public record GetNoteSourcesResponse
{
    public IReadOnlyList<NoteSourceInfo>? SharedLists { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
}

public record NoteSourceInfo
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

    public int Access { get; init; }

    public string? ShareType { get; init; }
}
