
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record AddAttachmentResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
    /// <summary>Populated by /api/upload on success (e.g. "att_guid_0.png").</summary>
    public string? Key { get; init; }
    /// <summary>Original filename returned by /api/upload.</summary>
    public string? FileName { get; init; }

    /// <summary>True if the upload succeeded by either protocol (success flag or key present).</summary>
    public bool IsUploaded => Success || !string.IsNullOrEmpty(Key);
}
