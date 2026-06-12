// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "folder" sub-object returned by file storage folder endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record FolderInfo
{
    public string? Name { get; init; }
    public string? Path { get; init; }
    public long Size { get; init; }
    public string? Version { get; init; }
    public JsonElement? SubFolders { get; init; }
    public long Count { get; init; }
    public JsonElement? Files { get; init; }
    public string? Id { get; init; }
    public string? FileName { get; init; }
    public string? Type { get; init; }
    public DateTime? DateAdded { get; init; }
    public bool Published { get; init; }
    public JsonElement? PublishedUntil { get; init; }
    public string? Password { get; init; }
    public string? PreviewImage { get; init; }
    public string? ShortLink { get; init; }
    public string? PublicDownloadLink { get; init; }
    public string? EncryptedIdString { get; init; }
    public string? FolderPath { get; init; }
    public bool AttachedFile { get; init; }
    public string? AttachedFileSourceType { get; init; }
    public string? AttachedFileSource { get; init; }
}
