
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ConnectToHubResponse
{
    public bool IsStandby { get; init; }
    public string? MachineName { get; init; }
    public JsonElement? SystemMount { get; init; }
    public JsonElement? SystemAdminUsernames { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
