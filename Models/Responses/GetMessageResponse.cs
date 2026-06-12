// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail /mail/message/full response wraps all message content
// in a nested "messageData" object. Only success/debugInfo are at the root.
// All message fields are on MessageDataInfo. Re-apply if models are regenerated.

#nullable enable

using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetMessageResponse
{
    public MessageDataInfo? MessageData { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}

