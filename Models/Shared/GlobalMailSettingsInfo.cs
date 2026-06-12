// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "globalMailSettings" sub-object returned by the global mail settings endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record GlobalMailSettingsInfo
{
    public string? ArchivePath { get; init; }
    public string? Domain { get; init; }
    public bool Incoming { get; init; }
    public bool Outgoing { get; init; }
    public int MonthsToKeep { get; init; }
    public bool Disabled { get; init; }
    public long ArchiveSize { get; init; }
}
