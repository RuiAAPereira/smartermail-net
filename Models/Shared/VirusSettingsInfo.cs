// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "settings" sub-object returned by the virus settings endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System;
using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record VirusSettingsInfo
{
    public string? QuarantineDirectory { get; init; }
    public bool EnableSpoolCommandLine { get; init; }
    public string? SpoolCommandLineFile { get; init; }
    public string? SpoolCommandLineArguments { get; init; }
    public double SpoolCommandLineTimeout { get; init; }
    public bool SpoolExecutableVisible { get; init; }
    public string? CommandLine { get; init; }
    public string? CommandLineArguments { get; init; }
    public bool CommandLineScanMessages { get; init; }
    public bool CommandLineScanMessagesWithoutAttachments { get; init; }
    public bool CommandLineScanFiles { get; init; }
    public JsonElement? Clam { get; init; }
    public string? IpAddress { get; init; }
    public int Port { get; init; }
    public bool IsRemoteServer { get; init; }
    public int TimeoutSeconds { get; init; }
    public int FailuresBeforeRestart { get; init; }
    public AntiVirusAction VirusAction { get; init; }
    public string? ActionData { get; init; }
    public DateTime? VirusDefinitionsUpdated { get; init; }
    public bool ScanMessages { get; init; }
    public bool ScanMessagesWithoutAttachments { get; init; }
}
