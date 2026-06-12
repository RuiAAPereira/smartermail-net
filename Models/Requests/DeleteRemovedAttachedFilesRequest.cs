
#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

public record DeleteRemovedAttachedFilesRequest
{
    public long FolderId { get; init; }
    public string? Owner { get; init; }
    public IReadOnlyList<string>? RemoveFileReferences { get; init; }
}
