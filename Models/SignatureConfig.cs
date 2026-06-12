#nullable enable

namespace SmarterMail.Net.Models;

/// <summary>A single email signature (user or domain).</summary>
public record SignatureConfig
{
    /// <summary>Numeric identifier of the signature.</summary>
    public long Id { get; init; }

    /// <summary>GUID identifier of the signature.</summary>
    public string? Guid { get; init; }

    /// <summary>Display name of the signature.</summary>
    public string? Name { get; init; }

    /// <summary>HTML content of the signature.</summary>
    public string? Text { get; init; }

    /// <summary>True if this is the default signature for new messages.</summary>
    public bool IsDefault { get; init; }
}
