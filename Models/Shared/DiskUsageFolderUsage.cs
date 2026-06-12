// MANUALLY PATCHED — do not overwrite with model generator output.
// Strongly-typed folder entry within DiskUsageInfo.Folders.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record DiskUsageFolderUsage
{
    public string? Name { get; init; }
    public long Used { get; init; }
}
