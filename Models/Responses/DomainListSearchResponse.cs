
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record DomainListSearchResponse
{
    public string? Name { get; init; }
    public string? IdnName { get; init; }
    public bool IsEnabled { get; init; }
    public long UserCount { get; init; }
    public int UserLimit { get; init; }
    public long AliasCount { get; init; }
    public int AliasLimit { get; init; }
    public long ListCount { get; init; }
    public int ListLimit { get; init; }
    public long EasMailboxCount { get; init; }
    public int EasMailboxLimit { get; init; }
    public long MapiEwsMailboxCount { get; init; }
    public int MapiEwsMailboxLimit { get; init; }
    public long PrimarySize { get; init; }
    public long SecondarySize { get; init; }
    public long Size { get; init; }
    public long MaxSize { get; init; }
    public int Percent { get; init; }
    public int PrimaryPercent { get; init; }
    public int SecondaryPercent { get; init; }
    public bool MessageArchivingEnabled { get; init; }
    public bool CriticallyErrored { get; init; }
    public string? DomainPath { get; init; }
    public bool IsSplitDomain { get; init; }
}
