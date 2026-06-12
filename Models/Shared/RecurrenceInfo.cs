// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "recurrence" sub-object inside task responses.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

public record RecurrenceInfo
{
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
}
