
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record AttachToVirtualFoldersResponse
{
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
