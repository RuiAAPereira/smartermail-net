#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models;

namespace SmarterMail.Net.Models.Responses;

public record GetUserSignatureMappingsResponse
{
    public IReadOnlyList<SignatureMap>? SignatureMaps { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
