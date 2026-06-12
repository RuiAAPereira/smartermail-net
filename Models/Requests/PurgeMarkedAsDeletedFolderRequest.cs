
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record PurgeMarkedAsDeletedFolderRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
}
