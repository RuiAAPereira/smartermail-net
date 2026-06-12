#nullable enable

using System;
using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AddNoteRequest
{
    public JsonElement? CategoriesMetaData { get; init; }
    public string? Name { get; init; }
    public bool Master { get; init; }
    public bool IsPlainText { get; init; }
    public string? Color { get; init; }
    public string? Subject { get; init; }
    public string? Text { get; init; }
    public SmarterMail.Net.Models.Enums.NoteType Type { get; init; }
    public string? AttachmentGuid { get; init; }
    public bool HasAttachments { get; init; }
    public string? SourceName { get; init; }
    public string? SourceId { get; init; }
    public string? SourceOwner { get; init; }
    public JsonElement? AttachedFiles { get; init; }
}
