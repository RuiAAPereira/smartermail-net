// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetVirusSettingsResponse
{
    public VirusSettingsInfo? Settings { get; init; }
    public CyrenServiceInfo? Cyren { get; init; }
    public DefenderServiceInfo? Defender { get; init; }
    public bool ScanUploadedFiles { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}