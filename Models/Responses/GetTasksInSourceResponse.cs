// MANUALLY PATCHED — do not overwrite with model generator output.
// GET /api/v1/tasks/{owner}/{sourceId}/ (no task id) returns ALL tasks in the
// source as a "details" ARRAY (the web client's task grid loads tasks this way;
// the tasks-all search endpoint is unreliable and returns an empty set on live).
// Re-apply if models are regenerated.

#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetTasksInSourceResponse
{
    public List<TaskDetailsInfo>? Details { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
