#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for <c>GET /api/v1/notes/notes/{owner}/{sourceId}/</c>.</summary>
public record GetNotesInSourceResponse
{
    public long Count { get; init; }
    public List<NoteInfo>? Notes { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
}
