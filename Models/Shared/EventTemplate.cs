#nullable enable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Shared;

/// <summary>An available event template, including the actions a hook may attach.</summary>
public record EventTemplate
{
    /// <summary>Numeric event id. Note: the server returns this as "eventId" (camelCase) here.</summary>
    public long EventId { get; init; }

    /// <summary>Event identifier, e.g. "LocalMessageDelivered".</summary>
    public string? Id { get; init; }

    /// <summary>Category resource id, e.g. "@Email".</summary>
    public string? CategoryResourceId { get; init; }

    public IReadOnlyList<JsonElement> Conditions { get; init; } = Array.Empty<JsonElement>();

    public IReadOnlyList<EventAction> PossibleActions { get; init; } = Array.Empty<EventAction>();

    [JsonExtensionData]
    public Dictionary<string, JsonElement>? Extra { get; init; }
}
