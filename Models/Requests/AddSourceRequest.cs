
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AddSourceRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public string? Uid { get; init; }
}
