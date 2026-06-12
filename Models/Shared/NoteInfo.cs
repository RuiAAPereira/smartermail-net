// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail /notes/get response wraps all note content
// in a nested "note" object. This record represents that inner object.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record NoteInfo
{
    public JsonElement? CategoriesMetaData { get; init; }
    public string? Name { get; init; }
    public bool Master { get; init; }
    public bool IsPlainText { get; init; }
    public string? Color { get; init; }
    public string? Subject { get; init; }
    public string? Text { get; init; }
    public NoteType Type { get; init; }
    public string? AttachmentGuid { get; init; }
    public bool HasAttachments { get; init; }
    public string? Id { get; init; }
    public DateTime? LastModifiedUTC { get; init; }
    public DateTime? DateCreated { get; init; }
    public string? SourceName { get; init; }
    public string? SourceId { get; init; }
    public string? SourceOwner { get; init; }
    public JsonElement? AttachedFiles { get; init; }
    public string? Filename { get; init; }
    public string? ContentType { get; init; }
    public string? ContentId { get; init; }
    public bool IsInline { get; init; }
    public long Size { get; init; }
    public DateTime? CreatedDateUtc { get; init; }
    public string? FileReference { get; init; }
    public string? AlternateId { get; init; }
}
