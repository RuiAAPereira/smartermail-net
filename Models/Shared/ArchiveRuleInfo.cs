// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "rule" sub-object returned by the domain archive rule endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record ArchiveRuleInfo
{
    public string? ArchivePath { get; init; }
    public string? Domain { get; init; }
    public bool Incoming { get; init; }
    public bool Outgoing { get; init; }
    public int MonthsToKeep { get; init; }
    public bool Disabled { get; init; }
    public long ArchiveSize { get; init; }
}
