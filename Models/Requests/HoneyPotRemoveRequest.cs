
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record HoneyPotRemoveRequest
{
    public JsonElement? Ips { get; init; }
}
