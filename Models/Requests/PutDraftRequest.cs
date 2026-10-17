
#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Requests;

public record PutDraftRequest
{
    /// <summary>Message importance (serialized as a string, e.g. "normal"). Mirrors the send contract.</summary>
    public MessageImportance Importance { get; init; }

    /// <summary>
    /// Numeric draft priority the official webmail sends (<c>priority:1</c>). Optional; omitted when null.
    /// Distinct from <see cref="Importance"/> — exact value scheme is undocumented, so leave unset unless
    /// you have a verified value.
    /// </summary>
    public int? Priority { get; init; }

    /// <summary>ISO-8601 UTC scheduled-send time, if the draft is queued for later delivery.</summary>
    public string? ScheduledSend { get; init; }

    public bool IsReply { get; init; }
    public bool IsForward { get; init; }
    public string? DraftAttachedMessage { get; init; }
    public string? DraftExcludeFiles { get; init; }
    public string? DraftInlineToRemove { get; init; }
    public string? OriginalCidString { get; init; }
    public string? Bcc { get; init; }
    public string? Cc { get; init; }
    public DateTime? Date { get; init; }
    public string? From { get; init; }
    public string? SelectedFrom { get; init; }
    public string? ReplyTo { get; init; }
    public string? Subject { get; init; }
    public string? To { get; init; }
    public string? MessagePlainText { get; init; }
    public string? MessageHTML { get; init; }
    public bool MarkForFollowup { get; init; }
    public string? AttachmentGuid { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public long ReplyUid { get; init; }
    public string? ReplyOwner { get; init; }
    public string? ReplyFromFolder { get; init; }
    public long DraftUid { get; init; }
    public JsonElement? Actions { get; init; }
    public bool ReadReceiptRequested { get; init; }
    public bool DeliveryReceiptRequested { get; init; }
    public JsonElement? ExcludeFiles { get; init; }
    public JsonElement? InlineToRemove { get; init; }
    public JsonElement? AttachedMessages { get; init; }
    public long Uid { get; init; }
    public JsonElement? OriginalCidLinks { get; init; }
    public string? OriginalMeetingInvite { get; init; }
    public bool SendImmediately { get; init; }
}
