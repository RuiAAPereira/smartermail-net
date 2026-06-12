
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetBindingPortsRequest
{
    public string? Name { get; init; }
    public int Port { get; init; }
    public SmarterMail.Net.Models.Enums.IPBindingType Type { get; init; }
    public string? Description { get; init; }
    public bool IsTls { get; init; }
    public bool IsSSL { get; init; }
    public string? CertificatePath { get; init; }
    public string? Password { get; init; }
    public bool UseAutomatedCertificate { get; init; }
    public string? AutomatedCertificateFilename { get; init; }
    public JsonElement? BoundIpAddresses { get; init; }
    public string? Id { get; init; }
}
