
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteFilesRequest
{
    public JsonElement? FileIDs { get; init; }
}
