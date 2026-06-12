#nullable enable

using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.UserSettings;

/// <summary>Implements user settings operations via the SmarterMail HTTP API.</summary>
public sealed class UserSettingsModule : IUserSettingsModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="UserSettingsModule"/>.</summary>
    public UserSettingsModule(ISmarterMailHttpClient http) { _http = http; }

    /// <inheritdoc/>
    public Task<GetUserResponse> GetUserAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetUserResponse>("/api/v1/settings/user", cancellationToken);

    /// <inheritdoc/>
    public Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<UpdateUserResponse>("/api/v1/settings/user", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetUsersMailSettingsResponse> GetUserMailSettingsAsync(bool getPic, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetUsersMailSettingsResponse>(
            $"/api/v1/settings/user-mail/{getPic.ToString().ToLowerInvariant()}", cancellationToken);

    /// <inheritdoc/>
    public Task<SetUsersMailSettingsResponse> UpdateUserMailSettingsAsync(SetUsersMailSettingsRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<SetUsersMailSettingsResponse>("/api/v1/settings/user-mail", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetUsersSignaturesResponse> GetSignaturesAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetUsersSignaturesResponse>("/api/v1/settings/user-signatures", cancellationToken);

    /// <inheritdoc/>
    public Task<AddUserSignatureResponse> CreateSignatureAsync(AddUserSignatureRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddUserSignatureResponse>("/api/v1/settings/user-signature-put", request, cancellationToken);

    /// <inheritdoc/>
    public Task<UpdateUserSignatureResponse> UpdateSignatureAsync(UpdateUserSignatureRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<UpdateUserSignatureResponse>("/api/v1/settings/user-signature", request, cancellationToken);

    /// <inheritdoc/>
    public Task<SignatureDeleteResponse> DeleteSignatureAsync(string id, CancellationToken cancellationToken = default)
        => _http.PostAsync<SignatureDeleteResponse>(
            $"/api/v1/settings/user-signature-delete/{Uri.EscapeDataString(id)}", null, cancellationToken);

    /// <inheritdoc/>
    public Task<GetUserSignatureMappingsResponse> GetUserSignatureMapsAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetUserSignatureMappingsResponse>("/api/v1/settings/user-signature-maps", cancellationToken);

    /// <inheritdoc/>
    public Task<GetSignaturesMappingsResponse> GetSignaturesMappingsAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetSignaturesMappingsResponse>("/api/v1/settings/signature-mappings", cancellationToken);

    /// <inheritdoc/>
    public Task<SetSignaturesMappingsResponse> SetSignaturesMappingsAsync(SetSignaturesMappingsRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<SetSignaturesMappingsResponse>("/api/v1/settings/signature-mappings", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetEmailsSignaturesResponse> GetEmailsSignaturesAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetEmailsSignaturesResponse>("/api/v1/settings/emails-signatures", cancellationToken);

    /// <inheritdoc/>
    public Task<GetAutoResponderSettingsResponse> GetAutoResponderAsync(bool wantHtml, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetAutoResponderSettingsResponse>(
            $"/api/v1/settings/auto-responder/{wantHtml.ToString().ToLowerInvariant()}", cancellationToken);

    /// <inheritdoc/>
    public Task<AutoRespondersSetResponse> UpdateAutoResponderAsync(AutoRespondersSetRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AutoRespondersSetResponse>("/api/v1/settings/auto-responder", request, cancellationToken);

    /// <inheritdoc/>
    public async Task<bool> CheckSenderBlockedAsync(string email, CancellationToken cancellationToken = default)
    {
        var response = await _http.PostAsync<GetSenderBlockedResponse>(
            "/api/v1/settings/sender-blocked",
            new CheckSenderBlockedRequest { Email = email },
            cancellationToken).ConfigureAwait(false);
        return response.Result;
    }

    /// <inheritdoc/>
    public Task BlockSendersAsync(BlockSendersRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync("/api/v1/settings/block-senders", request, cancellationToken);

    /// <inheritdoc/>
    public Task UnblockSendersAsync(UnblockSendersRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync("/api/v1/settings/unblock-senders", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetSpamSettingsResponse> GetSpamSettingsAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetSpamSettingsResponse>("/api/v1/settings/spam-settings", cancellationToken);

    /// <inheritdoc/>
    public Task<SetSpamSettingsResponse> UpdateSpamSettingsAsync(SetSpamSettingsRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<SetSpamSettingsResponse>("/api/v1/settings/spam-settings", request, cancellationToken);

    /// <inheritdoc/>
    public Task<SearchAutoCompleteListPostResponse> SearchAutoCompleteListAsync(SearchAutoCompleteListPostRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<SearchAutoCompleteListPostResponse>("/api/v1/settings/auto-complete-list-search", request, cancellationToken);
}
