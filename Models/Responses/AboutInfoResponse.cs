
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record AboutInfoResponse
{
    public string? Version { get; init; }
    public SmarterMail.Net.Models.Enums.EditionType Edition { get; init; }
    public bool EnterpriseFunctionality { get; init; }
    public bool ActiveSyncEnabled { get; init; }
    public bool MapiEwsEnabled { get; init; }
}
