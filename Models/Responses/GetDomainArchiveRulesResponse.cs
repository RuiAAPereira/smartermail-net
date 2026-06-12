
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetDomainArchiveRulesResponse
{
    public string? ArchivePath { get; init; }
    public string? Domain { get; init; }
    public bool Incoming { get; init; }
    public bool Outgoing { get; init; }
    public int MonthsToKeep { get; init; }
    public bool Disabled { get; init; }
    public long ArchiveSize { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
