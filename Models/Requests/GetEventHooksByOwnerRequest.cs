#nullable enable

namespace SmarterMail.Net.Models.Requests;

/// <summary>Request body for POST /api/v1/settings/event-hooks-by-owner (scoped to the authenticated owner).</summary>
public record GetEventHooksByOwnerRequest
{
    /// <summary>Filters by event name; pass the stable hook name for idempotent lookup.</summary>
    public string? Name { get; init; }
    public bool SortDescending { get; init; }
    public long Count { get; init; }
    public long StartIndex { get; init; }
}
