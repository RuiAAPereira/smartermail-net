#nullable enable

using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Responses;

/// <summary>A spam action rule applied at a given weight threshold.</summary>
public record SpamAction
{
    /// <summary>Action type code (e.g. 0 = none, 4 = move to folder).</summary>
    [JsonPropertyName("actionType")] public int ActionType { get; init; }
    /// <summary>Argument for the action (e.g. folder name).</summary>
    [JsonPropertyName("argument")] public string? Argument { get; init; }
    /// <summary>Whether this is the server default action.</summary>
    [JsonPropertyName("isDefaultAction")] public bool IsDefaultAction { get; init; }
    /// <summary>First boolean option (meaning is action-type-specific).</summary>
    [JsonPropertyName("boolOption1")] public bool BoolOption1 { get; init; }
    /// <summary>Second boolean option (meaning is action-type-specific).</summary>
    [JsonPropertyName("boolOption2")] public bool BoolOption2 { get; init; }
    /// <summary>Execution order for chained actions (-1 = not set).</summary>
    [JsonPropertyName("executionOrder")] public int ExecutionOrder { get; init; }
}

/// <summary>User-level spam filter settings.</summary>
public record UserSpamSettings
{
    /// <summary>Whether the user overrides domain spam settings.</summary>
    [JsonPropertyName("overrideActive")] public bool OverrideActive { get; init; }
    /// <summary>Score threshold for low-confidence spam.</summary>
    [JsonPropertyName("lowWeight")] public int LowWeight { get; init; }
    /// <summary>Action taken for low-confidence spam.</summary>
    [JsonPropertyName("lowAction")] public SpamAction? LowAction { get; init; }
    /// <summary>Score threshold for medium-confidence spam.</summary>
    [JsonPropertyName("medWeight")] public int MedWeight { get; init; }
    /// <summary>Action taken for medium-confidence spam.</summary>
    [JsonPropertyName("medAction")] public SpamAction? MedAction { get; init; }
    /// <summary>Score threshold for high-confidence spam.</summary>
    [JsonPropertyName("highWeight")] public int HighWeight { get; init; }
    /// <summary>Action taken for high-confidence spam.</summary>
    [JsonPropertyName("highAction")] public SpamAction? HighAction { get; init; }
}

/// <summary>Response from GET /api/v1/settings/spam-settings.</summary>
public record GetSpamSettingsResponse
{
    /// <summary>User-level spam filter settings.</summary>
    [JsonPropertyName("userSettings")] public UserSpamSettings? UserSettings { get; init; }
    /// <summary>Whether the request succeeded.</summary>
    public bool Success { get; init; }
    /// <summary>Optional server message.</summary>
    public string? Message { get; init; }
}
