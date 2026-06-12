
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SimpleCategoryManageApiGetRequest
{
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
}
