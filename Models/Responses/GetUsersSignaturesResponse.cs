#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models;

namespace SmarterMail.Net.Models.Responses;

public record GetUsersSignaturesResponse
{
    public IReadOnlyList<SignatureConfig>? SignatureConfigs { get; init; }
    public bool UseDomainSignature { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
