
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ExportBannedUsersResponse
{
    public string? MimeType { get; init; }
    public string? Filename { get; init; }
    public long Length { get; init; }
    public JsonElement? Bytes { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
