
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AddDomainRequest
{
    public bool IsSplitDomain { get; init; }
    public string? SecondaryStoragePath { get; init; }
    public int SecondaryStorageAgeDays { get; init; }
}
