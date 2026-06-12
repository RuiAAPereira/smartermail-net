
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteFolderRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public string? ParentFolder { get; init; }
    public long FolderId { get; init; }
}
