// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail /mail/message/full response wraps all message content
// in a nested "messageData" object. This record represents that inner object.
// Re-apply this file if models are regenerated.

#nullable enable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Shared;

public record MessageDataInfo
{
    public string? MessageID { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public bool RequestingReadReceipt { get; init; }
    public bool RequestingDeliveryReceipt { get; init; }
    public string? Bcc { get; init; }
    public string? Cc { get; init; }
    public DateTime? Date { get; init; }
    public string? From { get; init; }
    public string? Folder { get; init; }
    public string? Header { get; init; }
    public int Importance { get; init; }
    public bool IsAnswered { get; init; }
    public bool IsDeleted { get; init; }
    public bool IsDraft { get; init; }
    public bool IsFlagged { get; init; }
    public bool IsForwarded { get; init; }
    public bool IsReceiptChecked { get; init; }
    public bool IsRecent { get; init; }
    public bool IsReplied { get; init; }
    public bool IsSeen { get; init; }
    public string? ReplyTo { get; init; }
    public string? Sender { get; init; }
    public long Size { get; init; }
    public string? Subject { get; init; }
    public string? To { get; init; }
    public long Uid { get; init; }
    public string? MessagePlainText { get; init; }
    public string? MessageHTML { get; init; }
    public string? Link { get; init; }
    public string? Filename { get; init; }
    /// <summary>
    /// For email attachments: the MIME type as a string (e.g. "image/jpeg").
    /// For calendar/recurrence messages: the recurrence type as a number
    /// (0=None, 1=Yearly, 2=Monthly, 3=Weekly, 4=Daily, 5=Hourly, 6=Minutely, 7=Secondly).
    /// Use <see cref="System.Text.Json.JsonElement.ValueKind"/> to distinguish.
    /// </summary>
    public JsonElement? Type { get; init; }
    public int PartID { get; init; }
    /// <summary>
    /// The message's attachments. For drafts this is the only reliable source: the
    /// <c>attachment-links</c> endpoint returns empty and <see cref="AllAttachmentsLink"/> is
    /// null/absent, yet this array is still populated (with <c>link:null</c> per entry).
    /// </summary>
    public List<MessageAttachmentInfo>? Attachments { get; init; }
    public string? AllAttachmentsLink { get; init; }
    public string? Name { get; init; }
    public string? Email { get; init; }
    public bool ImagesBlocked { get; init; }
    public bool BypassRemoteContent { get; init; }
    public bool IsCalendarMessage { get; init; }
    public bool PlainTextOnly { get; init; }
    public List<EmailAddressInfo>? ToAddresses { get; init; }
    public List<EmailAddressInfo>? CcAddresses { get; init; }
    public List<EmailAddressInfo>? BccAddresses { get; init; }
    public JsonElement? Start { get; init; }
    public JsonElement? End { get; init; }
    public JsonElement? Due { get; init; }
    public DateTime? ScheduledSendDate { get; init; }
    public JsonElement? AttachedMessage { get; init; }
    public JsonElement? Categories { get; init; }
    public JsonElement? BlockedContentOrigins { get; init; }
    public JsonElement? FlagInfo { get; init; }
    public JsonElement? SwappedToDoInfo { get; init; }
    public JsonElement? WeeklyDays { get; init; }
    public string? Raw { get; init; }
    public string? Owner { get; init; }

    // === calendar-only flat fields (kept flat for STJ deserialization) ===
    public string? CalendarId { get; init; }
    public string? CalendarOwner { get; init; }
    public string? Comment { get; init; }
    public string? Description { get; init; }
    public string? EventId { get; init; }
    public string? Location { get; init; }
    public string? Id { get; init; }
    public string? SourceId { get; init; }
    public string? SourceOwner { get; init; }
    public string? SourceName { get; init; }
    public string? AttachedMessageId { get; init; }
    public string? Reminder { get; init; }
    public bool Conflict { get; init; }
    public bool IsOrganizer { get; init; }
    public bool IsAllDay { get; init; }
    public bool IsCancel { get; init; }
    public bool IsReply { get; init; }
    public bool MeetingCancelled { get; init; }
    public bool NewerVersionFound { get; init; }
    public bool OlderVersionFound { get; init; }
    public bool Master { get; init; }
    public bool ShowAccept { get; init; }
    public bool ShowCheckAvailability { get; init; }
    public bool ShowDecline { get; init; }
    public bool ShowDelete { get; init; }
    public bool ShowDetails { get; init; }

    // === task-only flat fields ===
    public int Status { get; init; }
    public int ReminderIndex { get; init; }
    public int Priority { get; init; }
    public int PercentComplete { get; init; }

    // === recurrence flat fields ===
    public bool IsWeekdaysOnly { get; init; }
    public bool MonthlySpecificDay { get; init; }
    public bool UntilCountEnabled { get; init; }
    public bool UntilDateEnabled { get; init; }
    public bool YearlySpecificDate { get; init; }
    public int UntilCount { get; init; }
    public int DailyInterval { get; init; }
    public int WeeklyInterval { get; init; }
    public int MonthlyInterval { get; init; }
    public int MonthDay { get; init; }
    public int MonthlyPeriodIndex { get; init; }
    public int MonthlyPeriodDayIndex { get; init; }
    public int YearlyInterval { get; init; }
    public int YearlyMonthIndex { get; init; }
    public int YearlyDay { get; init; }
    public int YearlyPeriodIndex { get; init; }
    public DateTime? UntilDate { get; init; }

    // === typed projections (computed; not serialized) ===

    /// <summary>Calendar-specific fields, populated only when <see cref="IsCalendarMessage"/> is true.</summary>
    [JsonIgnore]
    public CalendarMessageInfo? Calendar => IsCalendarMessage
        ? new CalendarMessageInfo
        {
            CalendarId = CalendarId,
            CalendarOwner = CalendarOwner,
            Comment = Comment,
            Description = Description,
            EventId = EventId,
            Location = Location,
            Reminder = Reminder,
            Conflict = Conflict,
            IsOrganizer = IsOrganizer,
            IsAllDay = IsAllDay,
            IsCancel = IsCancel,
            IsReply = IsReply,
            MeetingCancelled = MeetingCancelled,
            NewerVersionFound = NewerVersionFound,
            OlderVersionFound = OlderVersionFound,
            Master = Master,
            ShowAccept = ShowAccept,
            ShowCheckAvailability = ShowCheckAvailability,
            ShowDecline = ShowDecline,
            ShowDelete = ShowDelete,
            ShowDetails = ShowDetails,
        }
        : null;

    /// <summary>Task-specific fields. Populated when the message represents a task.</summary>
    [JsonIgnore]
    public TaskMessageInfo Task => new()
    {
        Status = Status,
        ReminderIndex = ReminderIndex,
        Priority = Priority,
        PercentComplete = PercentComplete,
    };

    /// <summary>Recurrence rule fields for calendar/task messages.</summary>
    [JsonIgnore]
    public RecurrenceInfo Recurrence => new()
    {
        IsWeekdaysOnly = IsWeekdaysOnly,
        MonthlySpecificDay = MonthlySpecificDay,
        UntilCountEnabled = UntilCountEnabled,
        UntilDateEnabled = UntilDateEnabled,
        YearlySpecificDate = YearlySpecificDate,
        UntilCount = UntilCount,
        DailyInterval = DailyInterval,
        WeeklyInterval = WeeklyInterval,
        WeeklyDays = WeeklyDays,
        MonthlyInterval = MonthlyInterval,
        MonthDay = MonthDay,
        MonthlyPeriodIndex = MonthlyPeriodIndex,
        MonthlyPeriodDayIndex = MonthlyPeriodDayIndex,
        YearlyInterval = YearlyInterval,
        YearlyMonthIndex = YearlyMonthIndex,
        YearlyDay = YearlyDay,
        YearlyPeriodIndex = YearlyPeriodIndex,
        UntilDate = UntilDate,
    };
}
