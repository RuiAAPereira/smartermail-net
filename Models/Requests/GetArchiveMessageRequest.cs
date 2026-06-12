
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetArchiveMessageRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public long Uid { get; init; }
}
