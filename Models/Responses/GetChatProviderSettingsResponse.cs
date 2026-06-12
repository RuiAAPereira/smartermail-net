
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetChatProviderSettingsResponse
{
    public SmarterMail.Net.Models.Enums.ChatProviderTypeModel ProviderType { get; init; }
    public string? ServerUrl { get; init; }
    public string? ServiceUserId { get; init; }
    public string? PersonalAccessTokenEncrypted { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
