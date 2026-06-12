#nullable enable

using SmarterMail.Net.Models;

namespace SmarterMail.Net.Models.Requests;

public record SetSignaturesMappingsRequest
{
    public IReadOnlyList<SignatureMap>? SignatureMaps { get; init; }
    public IReadOnlyList<SignatureMap>? ToAdd { get; init; }
    public IReadOnlyList<string>? ToRemove { get; init; }
}
