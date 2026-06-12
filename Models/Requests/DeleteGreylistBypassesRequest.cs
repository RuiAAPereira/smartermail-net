
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteGreylistBypassesRequest
{
    public JsonElement? Ids { get; init; }
}
