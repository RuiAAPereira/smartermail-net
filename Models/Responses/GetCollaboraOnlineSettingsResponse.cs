
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetCollaboraOnlineSettingsResponse
{
    public bool Enabled { get; init; }
    public string? ServerUrl { get; init; }
    public int MaxConnections { get; init; }
    public int MaxConnectionsPerUser { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
