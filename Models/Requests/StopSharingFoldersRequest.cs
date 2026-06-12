
#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

public record StopSharingFoldersRequest
{
    public List<long>? FolderIds { get; init; }
}
