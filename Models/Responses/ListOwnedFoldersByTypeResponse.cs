
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ListOwnedFoldersByTypeResponse
{
    public JsonElement? Folders { get; init; }
    public long FolderId { get; init; }
    public string? FolderName { get; init; }
    public string? TranslatableName { get; init; }
    public SmarterMail.Net.Models.Enums.ShareType FolderType { get; init; }
    public string? FolderGuid { get; init; }
    public string? FolderPath { get; init; }
    public string? DisplayPath { get; init; }
    public bool IncludeSubfolders { get; init; }
    public bool IsPrimary { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
