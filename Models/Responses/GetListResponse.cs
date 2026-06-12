
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetListResponse
{
    public JsonElement? Items { get; init; }
    public JsonElement? Dt { get; init; }
    public JsonElement? SnoozedUntil { get; init; }
    public string? Id { get; init; }
    public string? Title { get; init; }
    public string? Body { get; init; }
    public string? Type { get; init; }
    public JsonElement? TextData { get; init; }
    public JsonElement? PopupAlertPopoutData { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
