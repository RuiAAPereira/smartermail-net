// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail notes/get response wraps all note content
// in a nested "note" object. Only success/message/variables are at the root.
// Re-apply if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetNoteResponse
{
    public NoteInfo? Note { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
