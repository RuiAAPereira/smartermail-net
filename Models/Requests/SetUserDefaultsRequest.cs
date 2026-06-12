
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetUserDefaultsRequest
{
    public SmarterMail.Net.Models.Enums.CalendarAutoCleanSetting CalendarAutoCleanMonths { get; init; }
    public bool HideFromGal { get; init; }
    public bool LockPassword { get; init; }
    public long MaxMailboxSize { get; init; }
    public string? ComposeFont { get; init; }
    public string? ComposeFontSize { get; init; }
    public bool ReplyFromToField { get; init; }
    public string? DefaultComposeDomain { get; init; }
    public SmarterMail.Net.Models.Enums.DeleteOptionType DeleteMailAction { get; init; }
    public SmarterMail.Net.Models.Enums.JunkOptionType JunkMailAction { get; init; }
    public SmarterMail.Net.Models.Enums.RemoveFromJunkOptionType RemoveFromJunkMailAction { get; init; }
    public int DelaySendOption { get; init; }
    public string? PlusAddressingOption { get; init; }
    public bool MarkPopDownloadsAsRead { get; init; }
    public bool RequestReadReceipts { get; init; }
    public bool RequestDeliveryReceipts { get; init; }
    public string? LocaleId { get; init; }
    public int TimeZoneIndex { get; init; }
    public JsonElement? Throttling { get; init; }
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
}
