
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record PutDraftResponse
{
    public long Uid { get; init; }
    public JsonElement? AttachmentInfo { get; init; }
    public long Size { get; init; }
    public string? ContentType { get; init; }
    public string? Extension { get; init; }
    public string? ActualFileName { get; init; }
    public string? GeneratedFileNameAndLocation { get; init; }
    public string? GeneratedFileName { get; init; }
    public string? ContentID { get; init; }
    public string? Link { get; init; }
    public bool IsDone { get; init; }
    public bool IsAttachedFile { get; init; }
    public JsonElement? AttachmentAsBytes { get; init; }
    public JsonElement? OriginalCidLinks { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
