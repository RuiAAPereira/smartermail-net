
#nullable enable

using System.Collections.Generic;
using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GenerateAttachmentLinksResponse
{
    /// <summary>Dictionary mapping part IDs to time-limited attachment download links.</summary>
    public Dictionary<string, AttachmentLinkInfo>? Links { get; init; }
    public string? Link { get; init; }
    public string? PreviewImage { get; init; }
    public string? AllAttachmentsLink { get; init; }
    public string? DebugInfo { get; init; }
    public string? Message { get; init; }
    public JsonElement? ResultCode { get; init; }
    public bool Success { get; init; }
}
