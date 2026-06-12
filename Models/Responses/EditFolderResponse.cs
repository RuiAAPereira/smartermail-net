
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record EditFolderResponse
{
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
}
