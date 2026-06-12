// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record ExportRawSpoolMessagesResponse
{
    public MessageDataInfo? MessageData { get; init; }
    public AttachedMessageInfo? AttachedMessage { get; init; }
    public JsonElement? FlagInfo { get; init; }
    public JsonElement? SwappedToDoInfo { get; init; }
    public bool PlainTextOnly { get; init; }
    public DateTime? ScheduledSendDate { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}