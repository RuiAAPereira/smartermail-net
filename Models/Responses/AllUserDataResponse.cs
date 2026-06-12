
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record AllUserDataResponse
{
    public long Id { get; init; }
    public string? Guid { get; init; }
    public string? Name { get; init; }
    public string? Text { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
