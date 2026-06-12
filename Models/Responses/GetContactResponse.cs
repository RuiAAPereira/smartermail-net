// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail contacts/get response wraps all contact content
// in a nested "contact" object. Only success/debugInfo are at the root.
// Re-apply if models are regenerated.

#nullable enable

using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetContactResponse
{
    public ContactInfo? Contact { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
