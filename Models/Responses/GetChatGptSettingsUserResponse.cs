
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetChatGptSettingsUserResponse
{
    public bool OverrideApiKey { get; init; }
    public string? ApiKey { get; init; }
    public int MaxMessagesPerDay { get; init; }
    public int CurrentMessagesSent { get; init; }
    public JsonElement? LastMessageSent { get; init; }
    public bool Enabled { get; init; }
    public SmarterMail.Net.Models.Enums.AiModel_Model AiModel { get; init; }
    public string? ModelId { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
