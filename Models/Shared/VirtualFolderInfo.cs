// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "virtualFolder" sub-object returned by virtual folder endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record VirtualFolderInfo
{
    public ShareAccess Access { get; init; }
    public bool IsMapped { get; init; }
    public bool IsSubscribedForImap { get; init; }
    public string? TreeName { get; init; }
    public long ParentFolderId { get; init; }
    public bool IsSubFolder { get; init; }
    public string? PathForIMAP { get; init; }
    public long OwnerId { get; init; }
    public string? OwnerUserName { get; init; }
    public string? OwnerDisplayName { get; init; }
    public string? OwnerDomain { get; init; }
    public string? DavLink { get; init; }
    public bool IsDomainResource { get; init; }
    public bool PermissionsDefinedInParent { get; init; }
    public string? Color { get; init; }
    public SharedResourceType SharedResourceType { get; init; }
    public string? EmailAlias { get; init; }
    public bool Enabled { get; init; }
    public bool AllowWebcalSubscription { get; init; }
    public string? LegacyFolderIdentifier { get; init; }
    public JsonElement? AccessUsers { get; init; }
    public long UserId { get; init; }
    public string? Username { get; init; }
    public JsonElement? AccessGroups { get; init; }
    public long UserGroupId { get; init; }
    public string? GroupName { get; init; }
    public long AccessPermissionCount { get; init; }
    public long FolderId { get; init; }
    public string? FolderName { get; init; }
    public string? TranslatableName { get; init; }
    public ShareType FolderType { get; init; }
    public string? FolderGuid { get; init; }
    public string? FolderPath { get; init; }
    public string? DisplayPath { get; init; }
    public bool IncludeSubfolders { get; init; }
    public bool IsPrimary { get; init; }
}
