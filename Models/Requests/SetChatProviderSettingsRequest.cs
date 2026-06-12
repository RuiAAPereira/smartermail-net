
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetChatProviderSettingsRequest
{
    public SmarterMail.Net.Models.Enums.ChatProviderTypeModel ProviderType { get; init; }
    public string? ServerUrl { get; init; }
    public string? ServiceUserId { get; init; }
}
