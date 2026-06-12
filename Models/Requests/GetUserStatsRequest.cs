
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetUserStatsRequest
{
    public string? Email { get; init; }
}
