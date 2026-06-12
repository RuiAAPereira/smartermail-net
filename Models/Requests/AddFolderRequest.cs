// MANUALLY PATCHED — do not overwrite with model generator output.
// The generator emitted only ParentFolderId, but the live API
// (POST /api/v1/folders/folder-put — AddFolder) actually expects:
//   folder           [Required]  — the new folder's name
//   parentFolder                  — the parent folder path (null/empty for root)
//   ownerEmailAddress
//   folderId / folderGuid         — used only for find-by-id flows, irrelevant on create
// Verified against https://mail.smartertools.com/Documentation/detail/SmarterMail.Web.Api.FolderController
// Re-apply this file if models are regenerated.

#nullable enable

namespace SmarterMail.Net.Models.Requests;

public record AddFolderRequest
{
    public string? Folder { get; init; }
    public string? ParentFolder { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public long FolderId { get; init; }
    public string? FolderGuid { get; init; }
}
