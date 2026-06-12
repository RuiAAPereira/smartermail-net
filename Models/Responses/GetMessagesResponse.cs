#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetMessagesResponse
{
    public int TotalCount { get; init; }
    public int UnreadCount { get; init; }
    public List<SmarterMail.Net.Models.Shared.MessageSummaryInfo>? Results { get; init; }
    public List<long>? RemovedIds { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
