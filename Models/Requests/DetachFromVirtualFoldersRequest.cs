
#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

public record DetachFromVirtualFoldersRequest
{
    public List<long>? FolderIds { get; init; }
}
