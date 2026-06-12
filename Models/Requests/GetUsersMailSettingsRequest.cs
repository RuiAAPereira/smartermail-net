
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetUsersMailSettingsRequest
{
    public string? Email { get; init; }
}
