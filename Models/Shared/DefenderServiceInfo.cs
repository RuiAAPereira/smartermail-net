// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "defender" sub-object returned by the virus settings endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record DefenderServiceInfo
{
    public AntiVirusAction VirusAction { get; init; }
    public bool ScanMessages { get; init; }
    public bool ScanMessagesWithoutAttachments { get; init; }
    public bool ScanUploadedFiles { get; init; }
}
