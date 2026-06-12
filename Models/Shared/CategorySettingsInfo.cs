// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "categorySettings" sub-object returned by the user category list endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record CategorySettingsInfo
{
    public string? DefaultCategory { get; init; }
    public List<CategoryItem>? Categories { get; init; }
}
