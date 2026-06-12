
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record CreateDisposableAddressResponse
{
    public string? Address { get; init; }
    public DateTime? ExpireTime { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
