// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "settings" sub-object returned by the user defaults endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record UserDefaultsSettingsInfo
{
    public CalendarAutoCleanSetting CalendarAutoCleanMonths { get; init; }
    public bool HideFromGal { get; init; }
    public bool LockPassword { get; init; }
    public long MaxMailboxSize { get; init; }
    public string? ComposeFont { get; init; }
    public string? ComposeFontSize { get; init; }
    public bool ReplyFromToField { get; init; }
    public string? DefaultComposeDomain { get; init; }
    public DeleteOptionType DeleteMailAction { get; init; }
    public JunkOptionType JunkMailAction { get; init; }
    public RemoveFromJunkOptionType RemoveFromJunkMailAction { get; init; }
    public int DelaySendOption { get; init; }
    public string? PlusAddressingOption { get; init; }
    public bool MarkPopDownloadsAsRead { get; init; }
    public bool RequestReadReceipts { get; init; }
    public bool RequestDeliveryReceipts { get; init; }
    public string? LocaleId { get; init; }
    public int TimeZoneIndex { get; init; }
    public JsonElement? Throttling { get; init; }
}
