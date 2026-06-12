#nullable enable

using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Tasks;

/// <summary>Operations for the authenticated user's tasks.</summary>
public interface ITasksModule
{
    /// <summary>Searches for tasks matching the specified criteria.</summary>
    Task<GetAllTasksResponse> GetTasksAsync(GetAllTasksRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves a specific task by owner, source, and task ID.</summary>
    Task<GetTasksResponse> GetTaskAsync(string owner, string sourceId, string taskId = "", bool getAttachedMessage = false, CancellationToken cancellationToken = default);

    /// <summary>Creates or updates a task (upsert).</summary>
    Task<SaveTasksResponse> SaveTaskAsync(SaveTasksRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes a task by owner, source, and task ID.</summary>
    Task DeleteTaskAsync(string owner, string sourceId, string taskId, CancellationToken cancellationToken = default);

    /// <summary>Lists the user's task sources (task lists).</summary>
    Task<GetTaskSourcesResponse> GetSourcesAsync(CancellationToken cancellationToken = default);
}
