
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ChangeDomainPathRequest
{
    public string? OldDomainPath { get; init; }
}
