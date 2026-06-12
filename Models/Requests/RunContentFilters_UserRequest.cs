
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record RunContentFilters_UserRequest
{
    public JsonElement? ToRun { get; init; }
}
