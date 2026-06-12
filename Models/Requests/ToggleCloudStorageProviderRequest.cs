
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ToggleCloudStorageProviderRequest
{
    public string? ProviderKey { get; init; }
}
