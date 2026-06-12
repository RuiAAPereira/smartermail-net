
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteCloudStorageFilesRequest
{
    public JsonElement? FileIDs { get; init; }
}
