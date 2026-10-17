#nullable enable

using System;
using System.Collections.Generic;
using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Requests;

/// <summary>
/// Request body for POST /api/v1/settings/event-hook (AddEventHook). Models the event-hook
/// envelope verified against the live API, not a single action.
/// </summary>
public record AddEventHookRequest
{
    public bool IsNew { get; init; } = true;
    public bool Enabled { get; init; } = true;

    /// <summary>Numeric event id. Received mail = 30000 (LocalMessageDelivered).</summary>
    public long EventID { get; init; }

    /// <summary>Category resource id, e.g. "@Email".</summary>
    public string? EventGroup { get; init; }

    /// <summary>Empty/omitted on create; the server assigns the guid.</summary>
    public string? Id { get; init; }

    public string? Name { get; init; }
    public string? Owner { get; init; }

    /// <summary>Filter conditions. Empty array = fire for every matching message.</summary>
    public IReadOnlyList<JsonElement> Conditions { get; init; } = Array.Empty<JsonElement>();

    public IReadOnlyList<EventAction> Actions { get; init; } = Array.Empty<EventAction>();

    public bool Repeating { get; init; }
}
