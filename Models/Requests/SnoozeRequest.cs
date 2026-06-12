
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SnoozeRequest
{
    public JsonElement? Ids { get; init; }
}
