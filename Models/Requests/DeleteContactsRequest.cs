
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteContactsRequest
{
    /// <summary>Contacts to delete. Each item identifies a single contact to remove.</summary>
    public IReadOnlyList<DeleteContactItem>? Contacts { get; init; }

    // Retained for back-compat with the singular delete path.
    public string? SourceOwner { get; init; }
    public string? SourceId { get; init; }
}

public record DeleteContactItem
{
    public string? SourceOwner { get; init; }
    public string? SourceId { get; init; }
    public string? Id { get; init; }
}
