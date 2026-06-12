#nullable enable

using System;
using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.FileStorage;

/// <summary>Implements file storage operations via the SmarterMail HTTP API.</summary>
public sealed class FileStorageModule : IFileStorageModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="FileStorageModule"/>.</summary>
    public FileStorageModule(ISmarterMailHttpClient http) { _http = http; }

    /// <inheritdoc/>
    public Task<GetFoldersResponse> GetFoldersAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetFoldersResponse>("/api/v1/filestorage/folders", cancellationToken);

    /// <inheritdoc/>
    public Task<GetFoldersResponse> GetFilesAsync(string service, string folderId, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetFoldersResponse>(
            $"/api/v1/filestorage/folder/{Uri.EscapeDataString(service)}/{Uri.EscapeDataString(folderId)}/files",
            cancellationToken);

    /// <inheritdoc/>
    public Task<DiskUsageSummaryResponse> GetDiskUsageAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<DiskUsageSummaryResponse>("/api/v1/filestorage/disk-usage-summary", cancellationToken);

    /// <inheritdoc/>
    public Task<GetFoldersResponse> CreateFolderAsync(string path, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetFoldersResponse>("/api/v1/filestorage/folder-put", new { path }, cancellationToken);

    /// <inheritdoc/>
    public Task<DeleteCloudStorageFilesResponse> DeleteFolderAsync(string path, CancellationToken cancellationToken = default)
        => _http.PostAsync<DeleteCloudStorageFilesResponse>("/api/v1/filestorage/delete-folder", new { path }, cancellationToken);

    /// <inheritdoc/>
    public Task<DeleteCloudStorageFilesResponse> DeleteFilesAsync(DeleteCloudStorageFilesRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<DeleteCloudStorageFilesResponse>("/api/v1/filestorage/delete-files", request, cancellationToken);

    /// <inheritdoc/>
    public Task<Stream> DownloadFileAsync(string fileId, CancellationToken cancellationToken = default)
        => _http.GetStreamAsync(
            $"/api/v1/filestorage/{Uri.EscapeDataString(fileId)}/download", cancellationToken);

    /// <inheritdoc/>
    public Task<RemoveAttachedFileResponse> RemoveAttachedFileAsync(DeleteRemovedAttachedFilesRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<RemoveAttachedFileResponse>("/api/v1/filestorage/remove-attached-file", request, cancellationToken);
}
