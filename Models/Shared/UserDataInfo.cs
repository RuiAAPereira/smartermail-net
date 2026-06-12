// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "userData" sub-object returned by user GET endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

using System;
using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record UserDataInfo
{
    public string? AdminId { get; init; }
    public string? CreateDate { get; init; }
    public string? Description { get; init; }
    public string? Domain { get; init; }
    public string? FullName { get; init; }
    public bool IsListModerator { get; init; }
    public int LastAcceptedPolicyVersion { get; init; }
    public JsonElement? Loaded { get; init; }
    public string? TempPassword { get; init; }
    public DateTime? TempPasswordExpUtc { get; init; }
    public bool PasswordLocked { get; init; }
    public UserServicePermissions Permissions { get; init; }
    public JsonElement? SecurityFlags { get; init; }
}
