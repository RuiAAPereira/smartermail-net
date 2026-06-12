#nullable enable

namespace SmarterMail.Net.Models.Shared;

/// <summary>Represents a normalized email folder node with nested children.</summary>
public sealed record MailFolderNode
{
    public long Id { get; init; }
    public long? ParentFolderId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Path { get; init; } = string.Empty;
    public long Unread { get; init; }
    public long TotalMessages { get; init; }
    public long Size { get; init; }
    public bool CanDelete { get; init; }
    public bool CanEdit { get; init; }
    public IReadOnlyList<MailFolderNode> SubFolders { get; init; } = Array.Empty<MailFolderNode>();
}
