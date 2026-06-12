// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetUserDefaultsResponse
{
    public UserDefaultsSettingsInfo? Settings { get; init; }
    public JsonElement? Services { get; init; }
    public bool MailForwarding { get; init; }
    public bool EnableEas { get; init; }
    public bool EnableMapiEws { get; init; }
    public bool NotifyOnCalendarReminders { get; init; }
    public bool NotifyOnChatMessages { get; init; }
    public bool NotifyOnNewEmails { get; init; }
    public bool DisableGreylisting { get; init; }
    public bool AllowRemoteContent { get; init; }
    public bool PreviewUsePreview { get; init; }
    public string? PreferredIndexer { get; init; }
    public bool KeepRecipients { get; init; }
    public bool DraftAutoSave { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}