
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetFilesRequest
{
    public JsonElement? FileIDs { get; init; }
}
