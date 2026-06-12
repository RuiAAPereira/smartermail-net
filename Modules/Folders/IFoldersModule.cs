#nullable enable

using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Folders;

/// <summary>Operations for the authenticated user's email folders and virtual folders.</summary>
public interface IFoldersModule
{
    /// <summary>Retrieves the list of email folders for the current user.</summary>
    Task<ListMailFoldersResponse> GetEmailFoldersAsync(CancellationToken cancellationToken = default);

    /// <summary>Retrieves all folders across all types.</summary>
    Task<ListAllFoldersResponse> GetAllFoldersAsync(CancellationToken cancellationToken = default);

    /// <summary>Creates a new email folder.</summary>
    Task<AddFolderResponse> CreateFolderAsync(AddFolderRequest request, CancellationToken cancellationToken = default);

    /// <summary>Updates an existing email folder.</summary>
    Task<EditFolderResponse> UpdateFolderAsync(EditFolderRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes an email folder.</summary>
    Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves all virtual (smart) folders.</summary>
    Task<ListAllVirtualFoldersResponse> GetVirtualFoldersAsync(ListAllVirtualFoldersRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves a specific virtual folder by ID.</summary>
    Task<GetVirtualFolderResponse> GetVirtualFolderAsync(string id, CancellationToken cancellationToken = default);

    /// <summary>Attaches folders to a virtual folder.</summary>
    Task<AttachToVirtualFoldersResponse> AttachToVirtualFolderAsync(AttachToVirtualFoldersRequest request, CancellationToken cancellationToken = default);

    /// <summary>Detaches folders from a virtual folder.</summary>
    Task<DetachFromVirtualFoldersResponse> DetachFromVirtualFolderAsync(DetachFromVirtualFoldersRequest request, CancellationToken cancellationToken = default);
}
