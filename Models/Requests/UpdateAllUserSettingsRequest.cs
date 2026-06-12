
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateAllUserSettingsRequest
{
    public JsonElement? GlobalUpdate { get; init; }
    public JsonElement? Emails { get; init; }
}
