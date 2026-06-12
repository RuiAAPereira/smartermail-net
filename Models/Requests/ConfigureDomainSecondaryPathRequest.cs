
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ConfigureDomainSecondaryPathRequest
{
    public string? Path { get; init; }
}
