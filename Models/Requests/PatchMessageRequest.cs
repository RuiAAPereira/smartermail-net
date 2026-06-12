
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record PatchMessageRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public JsonElement? Uid { get; init; }
    public bool MarkDeleted { get; init; }
    public bool MarkRead { get; init; }
    public bool MarkReplied { get; init; }
    public bool MarkForwarded { get; init; }
    public bool MarkFlagged { get; init; }
    public bool BypassRemoteContent { get; init; }
    public bool MarkSpam { get; init; }
    public bool MarkNotSpam { get; init; }
}
