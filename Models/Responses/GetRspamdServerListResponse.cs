
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetRspamdServerListResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
