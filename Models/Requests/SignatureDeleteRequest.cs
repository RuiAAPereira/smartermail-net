
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SignatureDeleteRequest
{
    public long Id { get; init; }
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
