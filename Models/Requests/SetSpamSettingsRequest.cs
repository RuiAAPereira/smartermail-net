#nullable enable

using System.Text.Json.Serialization;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Models.Requests;

/// <summary>Request body for POST /api/v1/settings/spam-settings.</summary>
public record SetSpamSettingsRequest
{
    /// <summary>Updated user spam filter settings.</summary>
    [JsonPropertyName("userSettings")] public UserSpamSettings? UserSettings { get; init; }
}
