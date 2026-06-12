#nullable enable

namespace SmarterMail.Net.Models.Shared;

/// <summary>Represents a time-limited link for a single downloadable attachment.</summary>
public record AttachmentLinkInfo
{
    /// <summary>The temporary URL to download the attachment.</summary>
    public string? Link { get; init; }

    /// <summary>A preview link to the attachment.</summary>
    public string? PreviewImage { get; init; }

    /// <summary>Unix timestamp (seconds) when the link expires.</summary>
    public double ExpiresAtUnixTimestamp { get; init; }
}
