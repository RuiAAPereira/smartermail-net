
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DismissRequest
{
    public JsonElement? Ids { get; init; }
}
