
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetAllNotesRequest
{
    public JsonElement? Sources { get; init; }
    public string? Owner { get; init; }
    public string? Id { get; init; }
    public JsonElement? SearchParams { get; init; }
    public JsonElement? Colors { get; init; }
    public JsonElement? Categories { get; init; }
    public bool ShowNonCategorized { get; init; }
    public JsonElement? FilterFlags { get; init; }
    public int Skip { get; init; }
    public int Take { get; init; }
    public string? Search { get; init; }
    public string? SortField { get; init; }
}
