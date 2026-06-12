
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateMailingListRequest
{
    public string? Description { get; init; }
    public string? ListAddress { get; init; }
    public string? ModeratorAddress { get; init; }
    public SmarterMail.Net.Models.Enums.PostingPermission PostingPermissions { get; init; }
    public bool DisableSubscriptions { get; init; }
    public bool EnableDigest { get; init; }
    public bool PrependSubject { get; init; }
    public string? Subject { get; init; }
    public bool RequirePassword { get; init; }
    public string? Password { get; init; }
    public int MaxMessagesSentPerHour { get; init; }
    public SmarterMail.Net.Models.Enums.ThrottlingActions MessagesAction { get; init; }
    public int MaxSmtpOutBandwidthPerHour { get; init; }
    public SmarterMail.Net.Models.Enums.ThrottlingActions BandwidthAction { get; init; }
    public bool Disabled { get; init; }
    public bool SendSubscribeEmail { get; init; }
    public bool SendUnsubscribeEmail { get; init; }
    public string? DigestMailbox { get; init; }
    public string? DigestSubject { get; init; }
    public bool DigestStripNonTextAttachments { get; init; }
    public long DigestSendTriggerSize { get; init; }
    public SmarterMail.Net.Models.Enums.DigestTrigger DigestSendTriggerType { get; init; }
    public SmarterMail.Net.Models.Enums.DigestSendType DigestSendType { get; init; }
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
