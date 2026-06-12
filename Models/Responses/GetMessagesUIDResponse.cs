
#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Responses;

public record GetMessagesUIDResponse
{
    public int TotalCount { get; init; }
    public List<long>? Results { get; init; }
    public List<long>? RemovedIds { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
