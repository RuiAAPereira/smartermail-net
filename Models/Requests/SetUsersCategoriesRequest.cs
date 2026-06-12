
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetUsersCategoriesRequest
{
    public JsonElement? Categories { get; init; }
}
