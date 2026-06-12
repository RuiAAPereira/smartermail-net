
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record UndoMessageResponse
{
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
