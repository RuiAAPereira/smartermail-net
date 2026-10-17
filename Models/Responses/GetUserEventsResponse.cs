#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response from POST /api/v1/settings/user-events. Templates keyed by event id (e.g. "30000").</summary>
/// <remarks>
/// Read-only: this response is deserialized but never re-serialized/round-tripped. Only the inner
/// <see cref="EventAction"/> template is cloned and re-posted (it carries its own <c>Extra</c>), so the
/// absence of a top-level extension-data bag here is intentional.
/// </remarks>
public record GetUserEventsResponse
{
    public Dictionary<string, EventTemplate>? Events { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
}
