
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetVirtualFolderPropertiesRequest
{
    public long FolderId { get; init; }
    public string? Color { get; init; }
}
