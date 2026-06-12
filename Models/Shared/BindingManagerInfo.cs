// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "bindingManager" sub-object returned by the binding info endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record BindingManagerInfo
{
    public JsonElement? AvailableAddresses { get; init; }
    public JsonElement? BindingInfo { get; init; }
    public InterNetworkVersion IpType { get; init; }
    public string? IpAddress { get; init; }
    public string? HostName { get; init; }
    public string? Description { get; init; }
    public JsonElement? PortIDs { get; init; }
    public JsonElement? BindingPorts { get; init; }
    public string? Name { get; init; }
    public int Port { get; init; }
    public IPBindingType Type { get; init; }
    public bool IsTls { get; init; }
    public bool IsSSL { get; init; }
    public string? CertificatePath { get; init; }
    public string? Password { get; init; }
    public bool UseAutomatedCertificate { get; init; }
    public string? AutomatedCertificateFilename { get; init; }
    public JsonElement? BoundIpAddresses { get; init; }
    public string? Id { get; init; }
}
