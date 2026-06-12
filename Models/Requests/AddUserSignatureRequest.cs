#nullable enable

using SmarterMail.Net.Models;

namespace SmarterMail.Net.Models.Requests;

public record AddUserSignatureRequest
{
    public SignatureConfig SignatureConfig { get; init; } = new();
}
