#nullable enable

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Shared;

/// <summary>A single input parameter of an event action (e.g. the webhook URL).</summary>
public record EventActionInput
{
    /// <summary>Input key, e.g. "webhookurl", "webhookmethod", "webhookheaders", "webhookpayload".</summary>
    public string? Key { get; init; }

    /// <summary>Input value.</summary>
    public string? Value { get; init; }

    /// <summary>Server-managed fields (inputType, required, hidden, ...) preserved on round-trip.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? Extra { get; init; }
}
