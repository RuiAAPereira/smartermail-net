
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetResourceEventOrganizerInfoResponse
{
    public string? User { get; init; }
    public string? Domain { get; init; }
    public string? CalId { get; init; }
    public string? EvtId { get; init; }
}
