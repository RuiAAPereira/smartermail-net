#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Shared;

/// <summary>
/// One entry of the message-read <c>attachments[]</c> array. For drafts the server returns
/// <see cref="Link"/> as <c>null</c> (no signed download link; generated on demand by
/// <see cref="PartID"/>), so callers must not require a non-empty link to surface the file.
/// </summary>
public record MessageAttachmentInfo
{
    /// <summary>Signed download link; <c>null</c> for drafts.</summary>
    public string? Link { get; init; }

    /// <summary>Original file name (e.g. "cg.png").</summary>
    public string? Filename { get; init; }

    /// <summary>MIME type as a string (e.g. "image").</summary>
    public JsonElement? Type { get; init; }

    /// <summary>MIME part id used to fetch the attachment.</summary>
    public int PartID { get; init; }

    /// <summary>Size in bytes.</summary>
    public long Size { get; init; }
}
