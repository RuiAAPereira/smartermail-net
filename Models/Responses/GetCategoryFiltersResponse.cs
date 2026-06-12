
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetCategoryFiltersResponse
{
    public string? Name { get; init; }
    public bool Master { get; init; }
}
