#nullable enable

using SmarterMail.Net.Models;

namespace SmarterMail.Net.Models.Requests;

public record UpdateAllUserSignatureRequest
{
    public IReadOnlyList<SignatureConfig> Signatures { get; init; } = [];
    public bool UseDomainSignature { get; init; }
}
