
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record RemoveMailingListsRequest
{
    public JsonElement? Ints { get; init; }
}
