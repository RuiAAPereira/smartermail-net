
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AddDomainSignatureRequest
{
    public JsonElement? SignatureConfig { get; init; }
    public long Id { get; init; }
    public string? Guid { get; init; }
    public string? Name { get; init; }
    public string? Text { get; init; }
}
