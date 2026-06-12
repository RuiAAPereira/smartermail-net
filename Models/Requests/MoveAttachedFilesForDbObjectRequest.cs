
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MoveAttachedFilesForDbObjectRequest
{
    public string? OldOwner { get; init; }
    public string? NewOwner { get; init; }
    public long OldFolderId { get; init; }
    public long OldItemId { get; init; }
    public long NewFolderId { get; init; }
}
