
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ExportPostersRequest
{
    public JsonElement? Ints { get; init; }
}
