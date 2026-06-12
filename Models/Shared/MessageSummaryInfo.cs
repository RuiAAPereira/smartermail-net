#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record MessageSummaryInfo
{
    public long Uid { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public bool IsNew { get; init; }
    public string? GridId { get; init; }
    public string? To { get; init; }
    public string? ReturnPath { get; init; }
    public string? Email { get; init; }
    public string? Name { get; init; }
    public string? FromAddress { get; init; }
    public string? Subject { get; init; }
    public string? Folder { get; init; }
    public long Size { get; init; }
    public DateTime? InternalDate { get; init; }
    public DateTime? DateSent { get; init; }
    public int Importance { get; init; }
    public JsonElement? Recipients { get; init; }
    public bool HasAttachments { get; init; }
    public bool IsCalendar { get; init; }
    public int AttachmentCount { get; init; }
    public string? AttachmentName { get; init; }
    public bool IsAnswered { get; init; }
    public bool IsDeleted { get; init; }
    public bool IsDraft { get; init; }
    public bool IsFlagged { get; init; }
    public bool IsForwarded { get; init; }
    public bool IsReceiptChecked { get; init; }
    public bool IsReplied { get; init; }
    public bool IsSeen { get; init; }
    public bool IsDelay { get; init; }
    public bool BypassRemoteContent { get; init; }
    public bool IsCalendarMessage { get; init; }
    public int Index { get; init; }
    public bool HasAttachedTask { get; init; }
    public bool HasEmbeddedMessage { get; init; }
    public List<string>? Categories { get; init; }
    public JsonElement? FlagInfo { get; init; }
}
