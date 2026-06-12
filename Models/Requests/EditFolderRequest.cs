
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record EditFolderRequest
{
    public string? NewFolder { get; init; }
    public string? NewParentFolder { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public string? ParentFolder { get; init; }
    public long FolderId { get; init; }
}
