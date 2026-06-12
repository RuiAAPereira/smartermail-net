#nullable enable

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response from POST /api/v1/settings/spam-settings.</summary>
public record SetSpamSettingsResponse
{
    /// <summary>Whether the update succeeded.</summary>
    public bool Success { get; init; }
    /// <summary>Optional server message.</summary>
    public string? Message { get; init; }
}
