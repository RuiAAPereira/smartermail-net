
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UnarchiveWorkspacesRequest
{
    public JsonElement? Ids { get; init; }
}
