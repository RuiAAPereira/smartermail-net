
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GridCountsResponse
{
    public long ListSubscribers { get; init; }
    public long DigestSubscribers { get; init; }
    public long Posters { get; init; }
    public long BannedUsers { get; init; }
    public long CustomFields { get; init; }
    public long Messages { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
