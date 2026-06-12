#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for <c>GET /api/v1/notes/sources</c>.</summary>
public record GetNoteSourcesResponse
{
    /// <summary>The user's note sources (note folders). Reuses the shared source descriptor shape.</summary>
    public List<CalendarSourceInfo>? Sources { get; init; }
}
