
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record SetVirtualFolderPropertiesResponse
{
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
