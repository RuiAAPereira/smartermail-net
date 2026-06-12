
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetSystemMessageRequest
{
    public string? Name { get; init; }
    public string? Subject { get; init; }
}
