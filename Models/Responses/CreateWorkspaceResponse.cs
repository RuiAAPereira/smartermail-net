
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record CreateWorkspaceResponse
{
    public long Id { get; init; }
    public string? FullId { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
