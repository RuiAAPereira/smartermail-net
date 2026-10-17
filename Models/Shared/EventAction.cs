#nullable enable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Shared;

/// <summary>
/// An event action attached to an event hook. For push we use the "WebhookAction".
/// Unknown server-managed fields are preserved via <see cref="Extra"/> so a template
/// fetched from user-events can be re-posted to AddEventHook without loss.
/// </summary>
public record EventAction
{
    /// <summary>Action type as a string enum, e.g. "WebhookAction" (sending the int 8 yields INVALID_PAYLOAD).</summary>
    public string? Key { get; init; }

    public long EventActionID { get; init; }

    public bool Constrained { get; init; }

    public IReadOnlyList<EventActionInput> Inputs { get; init; } = Array.Empty<EventActionInput>();

    [JsonExtensionData]
    public Dictionary<string, JsonElement>? Extra { get; init; }
}
