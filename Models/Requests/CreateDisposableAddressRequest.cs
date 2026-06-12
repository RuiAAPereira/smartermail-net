
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record CreateDisposableAddressRequest
{
    public string? FolderName { get; init; }
}
