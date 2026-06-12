#nullable enable

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response from the address-book create endpoint.</summary>
public record AddAddressBookResponse
{
    /// <summary>Numeric folder id of the created book.</summary>
    public long FolderId { get; init; }

    /// <summary>GUID of the created book.</summary>
    public string? FolderGuid { get; init; }

    /// <summary>Whether the call succeeded.</summary>
    public bool Success { get; init; }

    /// <summary>Server diagnostic message on failure.</summary>
    public string? DebugInfo { get; init; }
}

/// <summary>Response from the address-book edit/delete endpoints.</summary>
public record AddressBookResponse
{
    /// <summary>Whether the call succeeded.</summary>
    public bool Success { get; init; }

    /// <summary>Server diagnostic message on failure.</summary>
    public string? DebugInfo { get; init; }
}
