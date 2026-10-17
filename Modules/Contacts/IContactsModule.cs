#nullable enable

using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Contacts;

/// <summary>Operations for the authenticated user's contacts.</summary>
public interface IContactsModule
{
    /// <summary>Searches for contacts matching the specified criteria.</summary>
    Task<GetAllContactsResponse> GetContactsAsync(GetAllContactsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves a specific contact via the confirmed /contacts/get/{owner}/{sourceId}/{contactId} endpoint.</summary>
    Task<GetContactResponse> GetContactAsync(string user, string sourceId, string contactId, CancellationToken cancellationToken = default);

    /// <summary>Retrieves a contact group by owner, source, and group ID.</summary>
    Task<GetContactResponse> GetContactGroupAsync(string ownerUsername, string sourceId, string groupId, CancellationToken cancellationToken = default);

    /// <summary>Retrieves the authenticated user's contact folders (address books).</summary>
    Task<GetAddressBookResponse> GetAddressBookAsync(string? username = null, string? uid = null, CancellationToken cancellationToken = default);

    Task<GetContactSourcesResponse> GetContactSourcesAsync(CancellationToken cancellationToken = default);

    /// <summary>Creates a personal address-book folder.</summary>
    Task<AddAddressBookResponse> CreateAddressBookAsync(AddressBookRequest request, CancellationToken cancellationToken = default);

    /// <summary>Renames a personal address-book folder.</summary>
    Task<AddressBookResponse> RenameAddressBookAsync(AddressBookRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes a personal address-book folder.</summary>
    Task<AddressBookResponse> DeleteAddressBookAsync(AddressBookRequest request, CancellationToken cancellationToken = default);

    /// <summary>Creates a new contact for the specified user.</summary>
    Task<AddContactResponse> CreateContactAsync(string user, string? folderUid, AddContactRequest request, CancellationToken cancellationToken = default);

    /// <summary>Updates an existing contact.</summary>
    Task<EditContactResponse> UpdateContactAsync(string user, string sourceId, bool domainContact, EditContactRequest request, CancellationToken cancellationToken = default);

    Task<EditContactResponse> UpdateContactGroupAsync(string user, string sourceId, EditContactRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes one or more contacts in bulk.</summary>
    Task<DeleteContactsResponse> DeleteContactsAsync(DeleteContactsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Imports a collection of contacts into the specified folder.</summary>
    Task<AddContactsResponse> ImportContactsAsync(string user, string folderId, AddContactsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Exports a single contact to CSV or vCard format.</summary>
    Task<byte[]> ExportContactAsync(string id, string sourceOwner, string type, string responseType, CancellationToken cancellationToken = default);

    /// <summary>Exports multiple contacts to CSV or vCard format.</summary>
    Task<byte[]> ExportContactsAsync(string type, string responseType, ExportContactsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Uploads a contact photo image for the specified contact.</summary>
    Task<ContactImageUploadResponse> UploadContactImageAsync(string user, string contactId, string sourceId, bool domainContact, Stream fileContent, string fileName, CancellationToken cancellationToken = default);

    /// <summary>Gets the GAL (Global Address List) image link for the specified email address.</summary>
    Task<GalImageLinkResponse> GetGalImageLinkAsync(string email, CancellationToken cancellationToken = default);

    /// <summary>Gets the Global Address List contacts for the authenticated user's domain.</summary>
    Task<GetDomainAddressBookResponse> GetDomainAddressBookAsync(CancellationToken cancellationToken = default);

    /// <summary>Gets all contacts available as group members for the specified user.</summary>
    Task<GetAllContactMembersResponse> GetGroupMembersAsync(string ownerUsername, CancellationToken cancellationToken = default);

    /// <summary>Expands a contact group into a flat list of recipient emails.</summary>
    Task<UnpackGroupResponse> UnpackGroupAsync(string groupUid, string ownerUsername, bool ignoreSubgroups = true, CancellationToken cancellationToken = default);

    /// <summary>Downloads the raw bytes of a contact photo from the given URL or path.</summary>
    Task<byte[]> GetContactPhotoAsync(string photoUrl, CancellationToken cancellationToken = default);

    /// <summary>
    /// Parses a CSV or VCF file and returns the contacts it contains, without committing them.
    /// Calls POST /api/upload with context=contact-import.
    /// </summary>
    Task<ParseContactsImportResponse> ParseContactImportAsync(string ownerUsername, Stream fileContent, string fileName, string contentType, CancellationToken cancellationToken = default);
}
