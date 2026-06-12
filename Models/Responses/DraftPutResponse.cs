#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

/// <summary>
/// Response from POST /api/v1/mail/draft-put/{attachGuid}.
/// Returns the uid of the saved draft and whether the operation succeeded.
/// </summary>
public record DraftPutResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
    public long Uid { get; init; }
    /// <summary>Populated when the server found and bound attachments to this draft.</summary>
    public JsonElement? AttachmentInfo { get; init; }
}
