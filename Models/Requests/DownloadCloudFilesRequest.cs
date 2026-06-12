
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DownloadCloudFilesRequest
{
    public JsonElement? FileIDs { get; init; }
}
