
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AuthDeleteWorkspaceRequest
{
    public string? FullId { get; init; }
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
