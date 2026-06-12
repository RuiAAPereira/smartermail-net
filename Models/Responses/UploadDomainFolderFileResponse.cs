
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record UploadDomainFolderFileResponse
{
    public JsonElement? UploadResults { get; init; }
    public JsonElement? UploadData { get; init; }
    public string? Id { get; init; }
    public string? FileName { get; init; }
    public string? Type { get; init; }
    public long Size { get; init; }
    public DateTime? DateAdded { get; init; }
    public bool Published { get; init; }
    public string? Version { get; init; }
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
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
