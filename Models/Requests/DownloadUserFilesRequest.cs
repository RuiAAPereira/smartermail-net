
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DownloadUserFilesRequest
{
    public JsonElement? FileIDs { get; init; }
}
