
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetCalDavUrlsResponse
{
    public JsonElement? Urls { get; init; }
    public string? Name { get; init; }
}
