
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AttachDomainRequest
{
    public string? DomainPath { get; init; }
    public string? DomainArchivePathNew { get; init; }
    public string? DomainArchivePathOld { get; init; }
    public string? DomainSecondaryStoragePathNew { get; init; }
}
