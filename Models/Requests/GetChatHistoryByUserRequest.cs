
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetChatHistoryByUserRequest
{
    public string? Email { get; init; }
}
