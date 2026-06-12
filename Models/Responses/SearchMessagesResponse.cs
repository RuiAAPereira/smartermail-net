#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Responses;

public record SearchMessagesResponse
{
    public int TotalCount { get; init; }
    public int UnreadCount { get; init; }
    public List<SmarterMail.Net.Models.Shared.SearchMessageSummaryInfo>? Results { get; init; }
    public List<long>? RemovedIds { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}