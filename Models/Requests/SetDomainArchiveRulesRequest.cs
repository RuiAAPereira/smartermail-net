
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetDomainArchiveRulesRequest
{
    public string? ArchivePath { get; init; }
    public string? Domain { get; init; }
    public bool Incoming { get; init; }
    public bool Outgoing { get; init; }
    public int MonthsToKeep { get; init; }
    public bool Disabled { get; init; }
    public long ArchiveSize { get; init; }
}
