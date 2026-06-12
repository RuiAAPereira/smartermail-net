
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetEnabledMarketPlaceItemsResponse
{
    public bool EmclientEnabled { get; init; }
    public bool DomainAdminCanOverride { get; init; }
    public bool OnlyOfficeEnabled { get; init; }
    public bool CollaboraEnabled { get; init; }
    public bool DropboxEnabled { get; init; }
    public bool GoogleDriveEnabled { get; init; }
    public bool OneDriveEnabled { get; init; }
    public bool OwncloudEnabled { get; init; }
    public bool VBoxxEnabled { get; init; }
    public bool LeitzcloudEnabled { get; init; }
    public bool ChatGPTEnabled { get; init; }
    public bool RocketChatEnabled { get; init; }
    public bool SmarterMailChatEnabled { get; init; }
    public bool SmarterMailFileStoreEnabled { get; init; }
    public bool SmarterMailOnlineMeetingsEnabled { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
