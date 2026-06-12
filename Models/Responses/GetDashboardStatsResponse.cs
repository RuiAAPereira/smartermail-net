
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetDashboardStatsResponse
{
    public long SpoolCount { get; init; }
    public int UserActivity { get; init; }
    public int CurrentConnections { get; init; }
    public int IdsBlocks { get; init; }
    public int SelfBlacklist { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
