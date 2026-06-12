
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AttachDomainBatchRequest
{
    public JsonElement? Domains { get; init; }
    public string? DomainPath { get; init; }
    public string? DomainArchivePathNew { get; init; }
    public string? DomainArchivePathOld { get; init; }
    public string? DomainSecondaryStoragePathNew { get; init; }
}
