
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ListSystemMessagesResponse
{
    public JsonElement? SystemMessages { get; init; }
    public string? Name { get; init; }
    public DateTime? LastModified { get; init; }
    public bool NeedsSubject { get; init; }
    public string? Subject { get; init; }
    public string? Body { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
