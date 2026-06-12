
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteWorkspacesRequest
{
    public JsonElement? Ids { get; init; }
}
