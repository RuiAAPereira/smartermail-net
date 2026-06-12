
#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

public record DeleteMessagesRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public bool All { get; init; }
    public List<long>? UID { get; init; }

    /// <summary>
    /// When true (default), deleted messages are moved to the Deleted Items folder.
    /// Set to false to permanently delete (skip Trash).
    /// </summary>
    public bool MoveToDeleted { get; init; } = true;
}
