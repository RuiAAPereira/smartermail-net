// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "details" sub-object returned by the occurrence details endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record OccurrenceDetailsInfo
{
    public long Id { get; init; }
    public string? Uid { get; init; }
    public string? CalendarId { get; init; }
    public JsonElement? RecurrenceId { get; init; }
    public string? CalendarOwner { get; init; }
    public bool AllDay { get; init; }
    public JsonElement? Start { get; init; }
}
