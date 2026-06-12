
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record SharedResourceListResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
    public long OwnerId { get; init; }
    public string? OwnerUserName { get; init; }
    public string? OwnerDisplayName { get; init; }
    public string? OwnerDomain { get; init; }
    public string? TreeName { get; init; }
    public string? DavLink { get; init; }
    public bool IsDomainResource { get; init; }
    public bool PermissionsDefinedInParent { get; init; }
    public string? Color { get; init; }
    public SmarterMail.Net.Models.Enums.SharedResourceType SharedResourceType { get; init; }
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
    public SmarterMail.Net.Models.Enums.ShareType FolderType { get; init; }
    public string? FolderGuid { get; init; }
    public string? FolderPath { get; init; }
    public string? DisplayPath { get; init; }
    public bool IncludeSubfolders { get; init; }
    public bool IsPrimary { get; init; }
}
