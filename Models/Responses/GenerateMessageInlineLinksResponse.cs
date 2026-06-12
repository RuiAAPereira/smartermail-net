
#nullable enable

using System.Collections.Generic;
using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GenerateMessageInlineLinksResponse
{
    /// <summary>Dictionary mapping part IDs to time-limited inline image links.</summary>
    public Dictionary<string, InlineLinkInfo>? InlineLinks { get; init; }
    public string? DebugInfo { get; init; }
    public string? Message { get; init; }
    public JsonElement? ResultCode { get; init; }
    public bool Success { get; init; }
}
