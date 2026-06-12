
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record CreateDocumentFromTemplateRequest
{
    public string? Language { get; init; }
    public string? Folder { get; init; }
    public string? Fn { get; init; }
}
