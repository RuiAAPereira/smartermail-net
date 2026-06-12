
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteMailListSubscriberFieldDefinitionRequest
{
    public JsonElement? Ints { get; init; }
}
