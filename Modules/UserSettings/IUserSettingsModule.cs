#nullable enable

using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.UserSettings;

/// <summary>Operations for the authenticated user's account settings, mail settings, signatures, and auto-reply.</summary>
public interface IUserSettingsModule
{
    /// <summary>Retrieves the current user's account data.</summary>
    Task<GetUserResponse> GetUserAsync(CancellationToken cancellationToken = default);

    /// <summary>Updates the current user's account data.</summary>
    Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves the user's mail settings.</summary>
    Task<GetUsersMailSettingsResponse> GetUserMailSettingsAsync(bool getPic, CancellationToken cancellationToken = default);

    /// <summary>Updates the user's mail settings.</summary>
    Task<SetUsersMailSettingsResponse> UpdateUserMailSettingsAsync(SetUsersMailSettingsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves all email signatures for the current user.</summary>
    Task<GetUsersSignaturesResponse> GetSignaturesAsync(CancellationToken cancellationToken = default);

    /// <summary>Creates a new email signature.</summary>
    Task<AddUserSignatureResponse> CreateSignatureAsync(AddUserSignatureRequest request, CancellationToken cancellationToken = default);

    /// <summary>Updates an existing email signature.</summary>
    Task<UpdateUserSignatureResponse> UpdateSignatureAsync(UpdateUserSignatureRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes an email signature by ID.</summary>
    Task<SignatureDeleteResponse> DeleteSignatureAsync(string id, CancellationToken cancellationToken = default);

    /// <summary>Retrieves the authenticated user's own address-to-signature mappings.</summary>
    Task<GetUserSignatureMappingsResponse> GetUserSignatureMapsAsync(CancellationToken cancellationToken = default);

    /// <summary>Retrieves all address-to-signature mappings (user + domain + alias).</summary>
    Task<GetSignaturesMappingsResponse> GetSignaturesMappingsAsync(CancellationToken cancellationToken = default);

    /// <summary>Sets address-to-signature mappings. Full-replacement: send complete list in SignatureMaps.</summary>
    Task<SetSignaturesMappingsResponse> SetSignaturesMappingsAsync(SetSignaturesMappingsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves the user's and domain's email signatures (used for compose injection).</summary>
    Task<GetEmailsSignaturesResponse> GetEmailsSignaturesAsync(CancellationToken cancellationToken = default);

    /// <summary>Retrieves the auto-responder (out-of-office) settings.</summary>
    Task<GetAutoResponderSettingsResponse> GetAutoResponderAsync(bool wantHtml, CancellationToken cancellationToken = default);

    /// <summary>Updates the auto-responder (out-of-office) settings.</summary>
    Task<AutoRespondersSetResponse> UpdateAutoResponderAsync(AutoRespondersSetRequest request, CancellationToken cancellationToken = default);

    /// <summary>Checks whether a sender's email address is on the user's block list. Returns true if blocked.</summary>
    Task<bool> CheckSenderBlockedAsync(string email, CancellationToken cancellationToken = default);

    /// <summary>Adds one or more senders to the user's block list.</summary>
    Task BlockSendersAsync(BlockSendersRequest request, CancellationToken cancellationToken = default);

    /// <summary>Removes one or more senders from the user's block list.</summary>
    Task UnblockSendersAsync(UnblockSendersRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves the user's spam filter settings.</summary>
    Task<GetSpamSettingsResponse> GetSpamSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>Updates the user's spam filter settings.</summary>
    Task<SetSpamSettingsResponse> UpdateSpamSettingsAsync(SetSpamSettingsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Searches the auto-complete address list (GAL, contacts, and history) for recipient suggestions.</summary>
    Task<SearchAutoCompleteListPostResponse> SearchAutoCompleteListAsync(SearchAutoCompleteListPostRequest request, CancellationToken cancellationToken = default);
}
