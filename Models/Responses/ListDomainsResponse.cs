
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ListDomainsResponse
{
    public bool IsSplitDomain { get; init; }
    public string? SecondaryStoragePath { get; init; }
    public int SecondaryStorageAgeDays { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
