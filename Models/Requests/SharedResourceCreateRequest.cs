
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SharedResourceCreateRequest
{
    public string? FolderName { get; init; }
    public SmarterMail.Net.Models.Enums.ShareType FolderType { get; init; }
    public SmarterMail.Net.Models.Enums.SharedResourceType SharedResourceType { get; init; }
    public bool IsEnabled { get; init; }
    public string? EmailAlias { get; init; }
    public long UserId { get; init; }
    public string? Username { get; init; }
    public long UserGroupId { get; init; }
    public string? GroupName { get; init; }
}
