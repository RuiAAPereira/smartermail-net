
#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record ListMailFoldersResponse
{
    public int Count { get; init; }
    public List<MailFolderInfo>? FolderList { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
