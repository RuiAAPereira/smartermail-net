// Task-specific projection of MessageDataInfo.
// Populated only when the message represents a task.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record TaskMessageInfo
{
    public int Status { get; init; }
    public int ReminderIndex { get; init; }
    public int Priority { get; init; }
    public int PercentComplete { get; init; }
}
