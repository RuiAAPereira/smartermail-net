// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "folderRestrictions" sub-object returned by folder restriction endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record FolderRestrictionsInfo
{
    public JsonElement? RestrictedWords { get; init; }
}
