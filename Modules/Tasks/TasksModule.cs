#nullable enable

using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Tasks;

/// <summary>Implements task operations via the SmarterMail HTTP API.</summary>
public sealed class TasksModule : ITasksModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="TasksModule"/>.</summary>
    public TasksModule(ISmarterMailHttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc/>
    public Task<GetAllTasksResponse> GetTasksAsync(GetAllTasksRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetAllTasksResponse>("/api/v1/tasks/tasks-all", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetTasksResponse> GetTaskAsync(string owner, string sourceId, string taskId = "", bool getAttachedMessage = false, CancellationToken cancellationToken = default)
    {
        var url = $"/api/v1/tasks/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(sourceId)}";
        if (!string.IsNullOrEmpty(taskId))
        {
            url += $"/{Uri.EscapeDataString(taskId)}/{getAttachedMessage.ToString().ToLowerInvariant()}";
        }
        return _http.GetAsync<GetTasksResponse>(url, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<SaveTasksResponse> SaveTaskAsync(SaveTasksRequest request, CancellationToken cancellationToken = default)
    {
        // Live API expects a JSON array of full task objects at /save/ (trailing slash) and returns an array.
        var saved = await _http.PostAsync<SaveTasksResponse[]>(
            "/api/v1/tasks/save/", new[] { request }, cancellationToken).ConfigureAwait(false);
        return saved is { Length: > 0 } ? saved[0] : new SaveTasksResponse();
    }

    /// <inheritdoc/>
    public Task DeleteTaskAsync(string owner, string sourceId, string taskId, CancellationToken cancellationToken = default)
        => _http.PostAsync(
            "/api/v1/tasks/delete/",
            new[] { new DeleteTaskRequest { SourceOwner = owner, SourceId = sourceId, Id = taskId } },
            cancellationToken);

    /// <inheritdoc/>
    public Task<GetTaskSourcesResponse> GetSourcesAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetTaskSourcesResponse>("/api/v1/tasks/sources", cancellationToken);
}
