
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateFolderRequest
{
    public long FolderId { get; init; }
    public long ParentFolderId { get; init; }
}
