// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetContactFromSourceIdResponse
{
    public ContactInfo? Contact { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}