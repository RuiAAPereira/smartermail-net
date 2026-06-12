
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record FileStorageProviderGetLinkRequest
{
    public string? Folder { get; init; }
}
