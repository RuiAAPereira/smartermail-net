#nullable enable

namespace SmarterMail.Net.Models.Requests;

/// <summary>Identity of a task to delete (posted as an array element to <c>/api/v1/tasks/delete/</c>).</summary>
public record DeleteTaskRequest
{
    /// <summary>Owner (numeric local account name, e.g. "4065").</summary>
    public string? SourceOwner { get; init; }

    /// <summary>Source (task list) id.</summary>
    public string? SourceId { get; init; }

    /// <summary>Task id.</summary>
    public string? Id { get; init; }
}
