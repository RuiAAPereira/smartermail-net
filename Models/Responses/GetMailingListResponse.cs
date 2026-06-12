// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail mailing-lists/get response wraps all mailing list content
// in a nested "item" object. Only success/debugInfo are at the root.
// Re-apply if models are regenerated.

#nullable enable

using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetMailingListResponse
{
    public MailingListItemInfo? Item { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
