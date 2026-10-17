#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response from GET /api/v1/settings/event-hook/{guid}. `eventHook` is null when absent.</summary>
public record GetEventHookByGuidResponse
{
    public JsonElement? EventHook { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
}
