// MANUALLY PATCHED — do not overwrite with model generator output.
// The SmarterMail tasks/get response wraps all task content
// in a nested "details" object. Only success/debugInfo are at the root.
// Re-apply if models are regenerated.

#nullable enable

using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetTasksResponse
{
    public TaskDetailsInfo? Details { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
