
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteTasksRequest
{
    public string? SourceOwner { get; init; }
    public string? SourceId { get; init; }
}
