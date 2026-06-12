
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ConnectToHubRequest
{
    public string? HubAddress { get; init; }
}
