// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "requirements" sub-object returned by authentication endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

namespace SmarterMail.Net.Models.Shared;

public record PasswordRequirementsInfo
{
    public bool ReqCapital { get; init; }
    public int ReqLength { get; init; }
    public bool ReqLower { get; init; }
    public bool ReqNotUsername { get; init; }
    public bool ReqNumber { get; init; }
    public bool ReqSymbol { get; init; }
    public bool ReqNotCommon { get; init; }
}
