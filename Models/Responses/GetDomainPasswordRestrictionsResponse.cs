
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetDomainPasswordRestrictionsResponse
{
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
