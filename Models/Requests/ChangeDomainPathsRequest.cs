
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ChangeDomainPathsRequest
{
    public string? OldDomainPath { get; init; }
}
