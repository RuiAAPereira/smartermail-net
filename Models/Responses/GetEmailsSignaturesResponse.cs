
#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for <c>GET /api/v1/settings/emails-signatures</c>.</summary>
public record GetEmailsSignaturesResponse
{
    /// <summary>The current user's own signatures.</summary>
    public IReadOnlyList<SignatureConfig>? UserSignatures { get; init; }

    /// <summary>Signatures defined at the domain level.</summary>
    public IReadOnlyList<SignatureConfig>? DomainSignatures { get; init; }

    /// <summary>True if the function call succeeded.</summary>
    public bool Success { get; init; }

    /// <summary>If success is false, why the call failed.</summary>
    public string? Message { get; init; }
}
