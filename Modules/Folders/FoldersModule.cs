#nullable enable

using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Folders;

/// <summary>Implements folder operations via the SmarterMail HTTP API.</summary>
public sealed class FoldersModule : IFoldersModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="FoldersModule"/>.</summary>
    public FoldersModule(ISmarterMailHttpClient http) { _http = http; }

    /// <inheritdoc/>
    public Task<ListMailFoldersResponse> GetEmailFoldersAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<ListMailFoldersResponse>("/api/v1/folders/list-email-folders", cancellationToken);

    /// <inheritdoc/>
    public Task<ListAllFoldersResponse> GetAllFoldersAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<ListAllFoldersResponse>("/api/v1/folders/list-all-folders", cancellationToken);

    /// <inheritdoc/>
    public Task<AddFolderResponse> CreateFolderAsync(AddFolderRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddFolderResponse>("/api/v1/folders/folder-put", request, cancellationToken);

    /// <inheritdoc/>
    public Task<EditFolderResponse> UpdateFolderAsync(EditFolderRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<EditFolderResponse>("/api/v1/folders/folder-patch", request, cancellationToken);

    /// <inheritdoc/>
    public Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<DeleteFolderResponse>("/api/v1/folders/delete-folder", request, cancellationToken);

    /// <inheritdoc/>
    public Task<ListAllVirtualFoldersResponse> GetVirtualFoldersAsync(ListAllVirtualFoldersRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<ListAllVirtualFoldersResponse>("/api/v1/folders/list-all-virtual-folders", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetVirtualFolderResponse> GetVirtualFolderAsync(string id, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetVirtualFolderResponse>(
            $"/api/v1/folders/get-virtual-folder/{Uri.EscapeDataString(id)}", cancellationToken);

    /// <inheritdoc/>
    public Task<AttachToVirtualFoldersResponse> AttachToVirtualFolderAsync(AttachToVirtualFoldersRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AttachToVirtualFoldersResponse>("/api/v1/folders/attach-to-virtual-folders", request, cancellationToken);

    /// <inheritdoc/>
    public Task<DetachFromVirtualFoldersResponse> DetachFromVirtualFolderAsync(DetachFromVirtualFoldersRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<DetachFromVirtualFoldersResponse>("/api/v1/folders/detach-from-virtual-folders", request, cancellationToken);
}
