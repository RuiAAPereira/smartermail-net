// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "organizer" sub-object returned by calendar event save endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record OrganizerInfo
{
    public string? Name { get; init; }
    public string? Address { get; init; }
}
