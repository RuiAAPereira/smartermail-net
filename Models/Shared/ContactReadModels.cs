#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Shared;

/// <summary>An entry from the auto-complete-list-search response (GAL/contacts/history).</summary>
public record AutoCompleteEntry
{
    public string? EmailAddress { get; init; }
    public string? DisplayAs { get; init; }
    public string? Id { get; init; }
    public string? Uid { get; init; }
    public string? GroupUid { get; init; }
    public string? Source { get; init; }
    public string? SourceAccount { get; init; }
    public bool IsGroup { get; init; }
    public bool IsMailingList { get; init; }
}

/// <summary>A contact entry as returned by the group-members endpoint and inside a group's grouped-contacts array.</summary>
public record ContactMemberInfo
{
    public string? EmailAddress { get; init; }
    public List<string>? EmailAddressList { get; init; }
    public string? DisplayName { get; init; }
    public string? DisplayAs { get; init; }
    public long? ContactId { get; init; }
    public string? Id { get; init; }
    public string? Uid { get; init; }
    public long? FolderId { get; init; }
    public string? SourceId { get; init; }
}

/// <summary>An address-book folder as returned by the address-book endpoint.</summary>
public record AddressBookFolderInfo
{
    public string? FolderUid { get; init; }
    public string? Uid { get; init; }
    public string? Id { get; init; }
    public string? SourceId { get; init; }
    public string? Name { get; init; }
    public string? DisplayName { get; init; }
    public string? SourceName { get; init; }
    public string? SourceOwner { get; init; }
    public bool IsPersonal { get; init; }
}

/// <summary>A category assignment on a contact.</summary>
public record CategoryInfo
{
    public string? Name { get; init; }
    public int ColorIndex { get; init; }
    public string? Guid { get; init; }
}
