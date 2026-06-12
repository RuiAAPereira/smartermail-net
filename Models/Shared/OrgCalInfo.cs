// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "orgCalInfo" sub-object returned by calendar event save endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record OrgCalInfo
{
    public string? User { get; init; }
    public string? Domain { get; init; }
    public string? EvtId { get; init; }
    public string? CalId { get; init; }
}
