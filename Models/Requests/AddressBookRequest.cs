#nullable enable

namespace SmarterMail.Net.Models.Requests;

/// <summary>Request body for address-book folder add/edit/delete endpoints.</summary>
public record AddressBookRequest
{
    /// <summary>Optional owner; defaults to the authenticated user when null.</summary>
    public string? OwnerEmailAddress { get; init; }

    /// <summary>Folder (book) display name. Required for add and edit; ignored by delete.</summary>
    public string? Folder { get; init; }

    /// <summary>Address-book GUID. Required for edit and delete; omit for add.</summary>
    public string? Uid { get; init; }
}
