#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for the user's contact folder listing.</summary>
public record GetAddressBookResponse
{
    /// <summary>The address-book folders available to the user (personal + shared).</summary>
    public List<AddressBookFolderInfo>? Folders { get; init; }

    /// <summary>The contacts and groups returned by the address-book endpoint.</summary>
    public List<ContactInfo>? Contacts { get; init; }

    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
