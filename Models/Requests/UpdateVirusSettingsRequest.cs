
#nullable enable

using System;
using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateVirusSettingsRequest
{
    public string? QuarantineDirectory { get; init; }
    public bool EnableSpoolCommandLine { get; init; }
    public string? SpoolCommandLineFile { get; init; }
    public string? SpoolCommandLineArguments { get; init; }
    public int SpoolCommandLineTimeout { get; init; }
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
    public SmarterMail.Net.Models.Enums.AntiVirusAction VirusAction { get; init; }
    public string? ActionData { get; init; }
    public DateTime? VirusDefinitionsUpdated { get; init; }
    public bool ScanMessages { get; init; }
    public bool ScanMessagesWithoutAttachments { get; init; }
    public JsonElement? Cyren { get; init; }
    public JsonElement? Defender { get; init; }
    public bool ScanUploadedFiles { get; init; }
}
