
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetCollaboraSettingsRequest
{
    public bool Enabled { get; init; }
    public string? ServerUrl { get; init; }
    public int MaxConnections { get; init; }
}
