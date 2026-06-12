#nullable enable

using System;

namespace SmarterMail.Net.Models.Shared;

/// <summary>A file attached to a calendar event (request side; response-only fields omitted).</summary>
public record EventAttachedFile
{
    public string? Filename { get; init; }
    public string? ContentType { get; init; }
    public string? ContentId { get; init; }
    public bool IsInline { get; init; }
    public long Size { get; init; }
    public DateTime? CreatedDateUtc { get; init; }
    public string? FileReference { get; init; }
    public string? AlternateId { get; init; }
}
