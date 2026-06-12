// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail mailing-lists/get response wraps all mailing list content
// in a nested "item" object. This record represents that inner object.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record MailingListItemInfo
{
    public long Id { get; init; }
    public DateTime? CreatedOn { get; init; }
    public JsonElement? EditedOn { get; init; }
    public StatusTypes Status { get; init; }
    public DateTime? DigestLastSendDate { get; init; }
    public long ListSubscriberCount { get; init; }
    public long DigestSubscriberCount { get; init; }
    public long PosterCount { get; init; }
    public long BannedUserCount { get; init; }
    public string? ListCommandAddress { get; init; }
    public string? Description { get; init; }
    public string? ListAddress { get; init; }
    public string? ModeratorAddress { get; init; }
    public PostingPermission PostingPermissions { get; init; }
    public bool DisableSubscriptions { get; init; }
    public bool EnableDigest { get; init; }
    public bool PrependSubject { get; init; }
    public string? Subject { get; init; }
    public bool RequirePassword { get; init; }
    public string? Password { get; init; }
    public int MaxMessagesSentPerHour { get; init; }
    public ThrottlingActions MessagesAction { get; init; }
    public int MaxSmtpOutBandwidthPerHour { get; init; }
    public ThrottlingActions BandwidthAction { get; init; }
    public bool Disabled { get; init; }
    public bool SendSubscribeEmail { get; init; }
    public bool SendUnsubscribeEmail { get; init; }
    public string? DigestMailbox { get; init; }
    public string? DigestSubject { get; init; }
    public bool DigestStripNonTextAttachments { get; init; }
    public long DigestSendTriggerSize { get; init; }
    public DigestTrigger DigestSendTriggerType { get; init; }
    public DigestSendType DigestSendType { get; init; }
    public DateTime? DigestNextSendDate { get; init; }
    public bool DoubleOptIn { get; init; }
    public bool DisableListErrorReplies { get; init; }
    public string? ListToAddress { get; init; }
    public string? ListFromAddress { get; init; }
    public string? ListReplyToAddress { get; init; }
    public bool CustomUnsubscribe { get; init; }
    public string? UnsubscribeText { get; init; }
    public string? BaseUrl { get; init; }
    public bool ShowInGal { get; init; }
    public bool EnableSpamFiltering { get; init; }
    public JsonElement? SpamLowAction { get; init; }
    public JsonElement? SpamMedAction { get; init; }
    public JsonElement? SpamHighAction { get; init; }
}
