
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record FileStorageProviderResponse
{
    public string? CurrentFolderID { get; init; }
    public string? CurrentFolderName { get; init; }
    public JsonElement? Items { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
