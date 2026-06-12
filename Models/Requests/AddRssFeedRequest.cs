
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AddRssFeedRequest
{
    public long FolderId { get; init; }
    public string? Name { get; init; }
}
