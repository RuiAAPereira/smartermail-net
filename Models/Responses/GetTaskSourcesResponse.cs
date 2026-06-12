#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for <c>GET /api/v1/tasks/sources</c>.</summary>
public record GetTaskSourcesResponse
{
    /// <summary>The user's task sources (task lists). Reuses the shared source descriptor shape.</summary>
    public List<CalendarSourceInfo>? Sources { get; init; }
}
