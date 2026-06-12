
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetOwnedVirtualFolderPropertiesRequest
{
    public long FolderId { get; init; }
    public JsonElement? AccessUsers { get; init; }
    public long UserId { get; init; }
    public string? Username { get; init; }
    public JsonElement? AccessGroups { get; init; }
    public long UserGroupId { get; init; }
    public string? GroupName { get; init; }
}
