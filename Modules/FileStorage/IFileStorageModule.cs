#nullable enable

using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.FileStorage;

/// <summary>Operations for the authenticated user's file storage.</summary>
public interface IFileStorageModule
{
    /// <summary>Retrieves the root file storage folder listing.</summary>
    Task<GetFoldersResponse> GetFoldersAsync(CancellationToken cancellationToken = default);

    /// <summary>Retrieves files within a specific cloud storage folder.</summary>
    Task<GetFoldersResponse> GetFilesAsync(string service, string folderId, CancellationToken cancellationToken = default);

    /// <summary>Retrieves disk usage statistics for the current user.</summary>
    Task<DiskUsageSummaryResponse> GetDiskUsageAsync(CancellationToken cancellationToken = default);

    /// <summary>Creates a new folder in file storage.</summary>
    Task<GetFoldersResponse> CreateFolderAsync(string path, CancellationToken cancellationToken = default);

    /// <summary>Deletes a folder from file storage.</summary>
    Task<DeleteCloudStorageFilesResponse> DeleteFolderAsync(string path, CancellationToken cancellationToken = default);

    /// <summary>Deletes one or more files from file storage.</summary>
    Task<DeleteCloudStorageFilesResponse> DeleteFilesAsync(DeleteCloudStorageFilesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Downloads a file from file storage as a raw stream.</summary>
    Task<Stream> DownloadFileAsync(string fileId, CancellationToken cancellationToken = default);

    /// <summary>Removes one or more attached files (by file reference) from a calendar/message folder.</summary>
    Task<RemoveAttachedFileResponse> RemoveAttachedFileAsync(DeleteRemovedAttachedFilesRequest request, CancellationToken cancellationToken = default);
}
