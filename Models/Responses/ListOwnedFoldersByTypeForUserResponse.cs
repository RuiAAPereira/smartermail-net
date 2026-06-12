
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ListOwnedFoldersByTypeForUserResponse
{
    public long Count { get; init; }
    public JsonElement? FolderList { get; init; }
    public long Id { get; init; }
    public string? Guid { get; init; }
    public long FolderIdParent { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public long Size { get; init; }
    public string? TranslatedName { get; init; }
    public bool IsMarked { get; init; }
    public bool IsSubscribed { get; init; }
    public bool CanDelete { get; init; }
    public bool CanEdit { get; init; }
    public SmarterMail.Net.Models.Enums.OwnershipType Access { get; init; }
    public string? Name { get; init; }
    public string? Path { get; init; }
    public int Recent { get; init; }
    public int TotalMessages { get; init; }
    public int Unread { get; init; }
    public int Drafts { get; init; }
    public bool IsMappedFolder { get; init; }
    public bool IsMappedSubfolder { get; init; }
    public JsonElement? SubFolders { get; init; }
    public long ChangeNumber { get; init; }
    public string? DisplayPath { get; init; }
    public JsonElement? DelayedMessages { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
