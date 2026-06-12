#nullable enable

namespace SmarterMail.Net.Models.Shared;

/// <summary>Represents a time-limited link for a single inline (embedded) attachment.</summary>
public record InlineLinkInfo
{
    /// <summary>The temporary URL to access the inline attachment.</summary>
    public string? Link { get; init; }

    /// <summary>Unix timestamp (seconds) when the link expires.</summary>
    public double ExpiresAtUnixTimestamp { get; init; }
}
