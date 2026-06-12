
#nullable enable

using System;
using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetDetachingDomainsResponse
{
    public JsonElement? Domains { get; init; }
    public string? Domain { get; init; }
    public string? Phase { get; init; }
    public DateTime? StartedUtc { get; init; }
    public string? DomainPath { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
