// MANUALLY PATCHED - do not overwrite with model generator output.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

/// <summary>A single category entry within the categorySettings.categories array.</summary>
public record CategoryItem
{
    public string? Name { get; init; }
    public int ColorIndex { get; init; }
    public string? Guid { get; init; }
}
