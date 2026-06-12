#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Contacts;

/// <summary>Implements contact operations via the SmarterMail HTTP API.</summary>
public sealed class ContactsModule : IContactsModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="ContactsModule"/>.</summary>
    public ContactsModule(ISmarterMailHttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc/>
    public Task<GetAllContactsResponse> GetContactsAsync(GetAllContactsRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetAllContactsResponse>("/api/v1/contacts/contacts-all", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetContactResponse> GetContactAsync(string contactId, string folder, string emailAddress, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetContactResponse>(
            $"/api/v1/contacts/contact/{Uri.EscapeDataString(contactId)}/{Uri.EscapeDataString(folder)}/{Uri.EscapeDataString(emailAddress)}",
            cancellationToken);

    /// <inheritdoc/>
    public Task<GetContactResponse> GetContactGroupAsync(string ownerUsername, string sourceId, string groupId, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetContactResponse>(
            $"/api/v1/contacts/get/{Uri.EscapeDataString(ownerUsername)}/{Uri.EscapeDataString(sourceId)}/{Uri.EscapeDataString(groupId)}",
            cancellationToken);

    /// <inheritdoc/>
    public Task<GetAddressBookResponse> GetAddressBookAsync(string? username = null, string? uid = null, CancellationToken cancellationToken = default)
    {
        var path = "/api/v1/contacts/address-book";
        if (!string.IsNullOrEmpty(username))
            path += "/" + Uri.EscapeDataString(username);
        if (!string.IsNullOrEmpty(uid))
            path += "/" + Uri.EscapeDataString(uid);

        return _http.GetAsync<GetAddressBookResponse>(path, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<GetContactSourcesResponse> GetContactSourcesAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetContactSourcesResponse>("/api/v1/contacts/sources", cancellationToken);

    /// <inheritdoc/>
    public Task<AddAddressBookResponse> CreateAddressBookAsync(AddressBookRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddAddressBookResponse>("/api/v1/contacts/address-book/add", request, cancellationToken);

    /// <inheritdoc/>
    public Task<AddressBookResponse> RenameAddressBookAsync(AddressBookRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddressBookResponse>("/api/v1/contacts/address-book/edit", request, cancellationToken);

    /// <inheritdoc/>
    public Task<AddressBookResponse> DeleteAddressBookAsync(AddressBookRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddressBookResponse>("/api/v1/contacts/address-book/delete", request, cancellationToken);

    /// <inheritdoc/>
    public Task<AddContactResponse> CreateContactAsync(string user, string? folderUid, AddContactRequest request, CancellationToken cancellationToken = default)
    {
        var path = $"/api/v1/contacts/contact-put/{Uri.EscapeDataString(user)}";
        if (!string.IsNullOrWhiteSpace(folderUid))
            path += "/" + Uri.EscapeDataString(folderUid);

        return _http.PostAsync<AddContactResponse>(path, request, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<EditContactResponse> UpdateContactAsync(string user, string sourceId, bool domainContact, EditContactRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<EditContactResponse>(
            $"/api/v1/contacts/contact/{Uri.EscapeDataString(user)}/{Uri.EscapeDataString(sourceId)}/{domainContact.ToString().ToLowerInvariant()}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<EditContactResponse> UpdateContactGroupAsync(string user, string sourceId, EditContactRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<EditContactResponse>(
            $"/api/v1/contacts/contact/{Uri.EscapeDataString(user)}/{Uri.EscapeDataString(sourceId)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<DeleteContactsResponse> DeleteContactsAsync(DeleteContactsRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<DeleteContactsResponse>("/api/v1/contacts/delete-bulk", request, cancellationToken);

    /// <inheritdoc/>
    public Task<AddContactsResponse> ImportContactsAsync(string user, string folderId, AddContactsRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddContactsResponse>(
            $"/api/v1/contacts/contacts-put/{Uri.EscapeDataString(user)}/{Uri.EscapeDataString(folderId)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<byte[]> ExportContactAsync(string id, string sourceOwner, string type, string responseType, CancellationToken cancellationToken = default)
        => _http.GetBytesAsync(
            $"/api/v1/contacts/export/{Uri.EscapeDataString(id)}/{Uri.EscapeDataString(sourceOwner)}/{Uri.EscapeDataString(type)}/{Uri.EscapeDataString(responseType)}",
            cancellationToken);

    /// <inheritdoc/>
    public Task<byte[]> ExportContactsAsync(string type, string responseType, ExportContactsRequest request, CancellationToken cancellationToken = default)
        => _http.PostBytesAsync(
            $"/api/v1/contacts/export/{Uri.EscapeDataString(type)}/{Uri.EscapeDataString(responseType)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<ContactImageUploadResponse> UploadContactImageAsync(
        string user, string contactId, string sourceId, bool domainContact,
        Stream fileContent, string fileName, CancellationToken cancellationToken = default)
        => _http.PostMultipartAsync<ContactImageUploadResponse>(
            "/api/v1/contacts/image", fileContent, fileName, "file",
            new System.Collections.Generic.Dictionary<string, string>
            {
                ["user"] = user,
                ["contactID"] = contactId,
                ["sourceId"] = sourceId,
                ["domainContact"] = domainContact.ToString().ToLowerInvariant(),
            }, cancellationToken);

    /// <inheritdoc/>
    public Task<GalImageLinkResponse> GetGalImageLinkAsync(string email, CancellationToken cancellationToken = default)
        => _http.GetAsync<GalImageLinkResponse>(
            $"/api/v1/contacts/gal-image-link?email={Uri.EscapeDataString(email)}", cancellationToken);

    /// <inheritdoc/>
    public Task<GetDomainAddressBookResponse> GetDomainAddressBookAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetDomainAddressBookResponse>("/api/v1/contacts/domain/", cancellationToken);

    /// <inheritdoc/>
    public Task<GetAllContactMembersResponse> GetGroupMembersAsync(string ownerUsername, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetAllContactMembersResponse>(
            $"/api/v1/contacts/members/{Uri.EscapeDataString(ownerUsername)}",
            cancellationToken);

    /// <inheritdoc/>
    public async Task<UnpackGroupResponse> UnpackGroupAsync(
        string groupUid, string ownerUsername, bool ignoreSubgroups = true,
        CancellationToken cancellationToken = default)
    {
        // SmarterMail expects C# bool string form ("True"/"False"), not lowercase JSON convention.
        var root = await _http.GetAsync<System.Text.Json.JsonElement>(
            $"/api/v1/contacts/unpack-group/{Uri.EscapeDataString(groupUid)}/{Uri.EscapeDataString(ownerUsername)}/{ignoreSubgroups}",
            cancellationToken).ConfigureAwait(false);

        var success = root.ValueKind == System.Text.Json.JsonValueKind.Object
            && root.TryGetProperty("success", out var s)
            && s.ValueKind == System.Text.Json.JsonValueKind.True;
        return new UnpackGroupResponse { Success = success, Emails = ParseUnpackedEmails(root) };
    }

    /// <inheritdoc/>
    public Task<byte[]> GetContactPhotoAsync(string photoUrl, CancellationToken cancellationToken = default)
        => _http.GetBytesAsync(photoUrl, cancellationToken);

    /// <inheritdoc/>
    public Task<ParseContactsImportResponse> ParseContactImportAsync(
        string ownerUsername, Stream fileContent, string fileName, string contentType,
        CancellationToken cancellationToken = default)
    {
        var contextData = System.Text.Json.JsonSerializer.Serialize(new { source = ownerUsername });
        return _http.PostResumableUploadAsync<ParseContactsImportResponse>(
            "contact-import", contextData, fileContent, fileName, contentType, cancellationToken);
    }

    private static IReadOnlyList<string> ParseUnpackedEmails(System.Text.Json.JsonElement root)
    {
        var array = default(System.Text.Json.JsonElement);
        if (root.ValueKind == System.Text.Json.JsonValueKind.Array)
            array = root;
        else if (root.ValueKind == System.Text.Json.JsonValueKind.Object)
        {
            foreach (var key in new[] { "contacts", "results", "emailData" })
                if (root.TryGetProperty(key, out var arr) && arr.ValueKind == System.Text.Json.JsonValueKind.Array)
                {
                    array = arr;
                    break;
                }
        }

        if (array.ValueKind != System.Text.Json.JsonValueKind.Array)
            return System.Array.Empty<string>();

        var list = new List<string>();
        foreach (var el in array.EnumerateArray())
        {
            string? email = el.ValueKind == System.Text.Json.JsonValueKind.String
                ? el.GetString()
                : ReadEmail(el);
            if (!string.IsNullOrWhiteSpace(email))
                list.Add(email!);
        }
        return list;
    }

    private static string? ReadEmail(System.Text.Json.JsonElement el)
    {
        if (el.TryGetProperty("emailAddress", out var ea) && ea.ValueKind == System.Text.Json.JsonValueKind.String)
        {
            var s = ea.GetString();
            if (!string.IsNullOrWhiteSpace(s)) return s;
        }
        if (el.TryGetProperty("emailAddressList", out var list) && list.ValueKind == System.Text.Json.JsonValueKind.Array)
            foreach (var item in list.EnumerateArray())
                if (item.ValueKind == System.Text.Json.JsonValueKind.String && !string.IsNullOrWhiteSpace(item.GetString()))
                    return item.GetString();
        return null;
    }
}
