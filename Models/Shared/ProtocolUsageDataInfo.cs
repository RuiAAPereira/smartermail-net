// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "data" sub-object returned by the protocol usage and limits endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record ProtocolUsageDataInfo
{
    public long SystemEasCount { get; init; }
    public int SystemEasLimit { get; init; }
    public long DomainEasCount { get; init; }
    public int DomainEasLimit { get; init; }
    public long SystemMapiEwsCount { get; init; }
    public int SystemMapiEwsLimit { get; init; }
    public long DomainMapiEwsCount { get; init; }
}
