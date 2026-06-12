
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SaveTasksRequest
{
    public string? Id { get; init; }
    public string? SourceId { get; init; }
    public string? SourceOwner { get; init; }
    public string? SourceName { get; init; }
    public string? AttachedMessageId { get; init; }
    public JsonElement? Start { get; init; }
    public JsonElement? Due { get; init; }
    public JsonElement? Reminder { get; init; }
    public bool UseDateTime { get; init; }
    public bool ReminderSet { get; init; }
    public int Priority { get; init; }
    public int Status { get; init; }
    public int PercentComplete { get; init; }
    public string? Subject { get; init; }
    public string? Description { get; init; }
    public JsonElement? Categories { get; init; }
    public string? Name { get; init; }
    public bool Master { get; init; }
    public JsonElement? AttachedFiles { get; init; }
    public string? Filename { get; init; }
    public string? ContentType { get; init; }
    public string? ContentId { get; init; }
    public bool IsInline { get; init; }
    public long Size { get; init; }
    public DateTime? CreatedDateUtc { get; init; }
    public string? FileReference { get; init; }
    public string? AlternateId { get; init; }
    public JsonElement? AttachedMessage { get; init; }
    public string? To { get; init; }
    public string? From { get; init; }
    public DateTime? Date { get; init; }
    public long Uid { get; init; }
    public string? Owner { get; init; }
    public string? UserTimeZone { get; init; }
    public long ItemId { get; init; }
    public bool IsDelegatedByOwner { get; init; }
    public string? AssignedName { get; init; }
    public JsonElement? Recurrence { get; init; }
    public bool IsRegenerative { get; init; }
    public DateTime? StartDate { get; init; }
    public int Type { get; init; }
    public long UntilCount { get; init; }
    public bool UntilCountEnabled { get; init; }
    public DateTime? UntilDate { get; init; }
    public bool UntilDateEnabled { get; init; }
    public int DailyInterval { get; init; }
    public int WeeklyInterval { get; init; }
    public JsonElement? WeeklyDays { get; init; }
    public bool IsWeekdaysOnly { get; init; }
    public int MonthlyInterval { get; init; }
    public bool MonthlySpecificDay { get; init; }
    public int MonthDay { get; init; }
    public int MonthlyPeriodIndex { get; init; }
    public int MonthlyPeriodDayIndex { get; init; }
    public int YearlyInterval { get; init; }
    public bool YearlySpecificDate { get; init; }
    public int YearlyMonthIndex { get; init; }
    public int YearlyDay { get; init; }
    public int YearlyPeriodIndex { get; init; }
    public bool IsPrivate { get; init; }
    public SmarterMail.Net.Models.Enums.ShareAccess Permission { get; init; }
    public string? AttachmentGuid { get; init; }
}
