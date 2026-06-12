
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record AddUserSignatureResponse
{
    public long SignatureID { get; init; }
    public string? SignatureGuid { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
