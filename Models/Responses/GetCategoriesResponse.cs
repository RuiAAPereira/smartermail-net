
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetCategoriesResponse
{
    public string? Name { get; init; }
    public bool Master { get; init; }
}
