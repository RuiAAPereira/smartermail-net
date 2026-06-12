// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "cyren" sub-object returned by the virus settings endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record CyrenServiceInfo
{
    public AntiVirusAction VirusAction { get; init; }
    public string? ActionData { get; init; }
    public bool ScanMessages { get; init; }
}
