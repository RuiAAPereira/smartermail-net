
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetEventHooksByOwnerRequest
{
    public string? Name { get; init; }
    public bool SortDescending { get; init; }
    public long Count { get; init; }
}
