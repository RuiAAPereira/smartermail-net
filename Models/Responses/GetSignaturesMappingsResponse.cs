#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models;

namespace SmarterMail.Net.Models.Responses;

public record GetSignaturesMappingsResponse
{
    public IReadOnlyList<SignatureMap>? Maps { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
