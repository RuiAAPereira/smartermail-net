#nullable enable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

/// <summary>
/// Response from POST /api/v1/settings/event-hooks-by-owner. Items are kept as raw JSON
/// (the populated list shape is not yet modeled); callers typically branch on <see cref="Total"/>.
/// </summary>
public record GetEventHooksByOwnerResponse
{
    public IReadOnlyList<JsonElement> EventHooks { get; init; } = Array.Empty<JsonElement>();
    public long Total { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
}
