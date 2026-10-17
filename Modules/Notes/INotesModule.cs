#nullable enable

using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Notes;

/// <summary>Operations for the authenticated user's notes.</summary>
public interface INotesModule
{
    /// <summary>Searches for notes matching the specified criteria.</summary>
    Task<GetAllNotesResponse> GetNotesAsync(GetAllNotesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Lists all notes in a single source via the web client's per-source route.</summary>
    Task<GetNotesInSourceResponse> GetNotesInSourceAsync(string owner, string sourceId, CancellationToken cancellationToken = default);

    /// <summary>Retrieves a specific note by ID, folder, and owner.</summary>
    Task<GetNoteResponse> GetNoteAsync(string noteId, string folderId, string user = "", CancellationToken cancellationToken = default);

    /// <summary>Creates a new note in the specified folder.</summary>
    Task<AddNoteResponse> CreateNoteAsync(string folderId, string user, AddNoteRequest request, CancellationToken cancellationToken = default);

    /// <summary>Updates an existing note.</summary>
    Task<EditNoteResponse> UpdateNoteAsync(string noteId, string folderId, string user, EditNoteRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes a specific note.</summary>
    Task<DeleteNoteResponse> DeleteNoteAsync(string noteId, string folderId, string user, CancellationToken cancellationToken = default);

    /// <summary>Lists the user's note sources (note folders).</summary>
    Task<GetNoteSourcesResponse> GetSourcesAsync(CancellationToken cancellationToken = default);
}
