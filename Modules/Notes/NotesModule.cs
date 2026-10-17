#nullable enable

using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Notes;

/// <summary>Implements note operations via the SmarterMail HTTP API.</summary>
public sealed class NotesModule : INotesModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="NotesModule"/>.</summary>
    public NotesModule(ISmarterMailHttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc/>
    public Task<GetAllNotesResponse> GetNotesAsync(GetAllNotesRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetAllNotesResponse>("/api/v1/notes/notes-all", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetNotesInSourceResponse> GetNotesInSourceAsync(string owner, string sourceId, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetNotesInSourceResponse>(
            $"/api/v1/notes/notes/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(sourceId)}/",
            cancellationToken);

    /// <inheritdoc/>
    public Task<GetNoteResponse> GetNoteAsync(string noteId, string folderId, string user = "", CancellationToken cancellationToken = default)
    {
        var path = string.IsNullOrEmpty(user)
            ? $"/api/v1/notes/note/{Uri.EscapeDataString(noteId)}/{Uri.EscapeDataString(folderId)}"
            : $"/api/v1/notes/note/{Uri.EscapeDataString(noteId)}/{Uri.EscapeDataString(folderId)}/{Uri.EscapeDataString(user)}";
        return _http.GetAsync<GetNoteResponse>(path, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<AddNoteResponse> CreateNoteAsync(string folderId, string user, AddNoteRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddNoteResponse>(
            $"/api/v1/notes/note-put/{Uri.EscapeDataString(folderId)}/{Uri.EscapeDataString(user)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<EditNoteResponse> UpdateNoteAsync(string noteId, string folderId, string user, EditNoteRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<EditNoteResponse>(
            $"/api/v1/notes/note-patch/{Uri.EscapeDataString(noteId)}/{Uri.EscapeDataString(folderId)}/{Uri.EscapeDataString(user)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<DeleteNoteResponse> DeleteNoteAsync(string noteId, string folderId, string user, CancellationToken cancellationToken = default)
        => _http.PostAsync<DeleteNoteResponse>(
            $"/api/v1/notes/note-delete/{Uri.EscapeDataString(noteId)}/{Uri.EscapeDataString(folderId)}/{Uri.EscapeDataString(user)}",
            null, cancellationToken);

    /// <inheritdoc/>
    public Task<GetNoteSourcesResponse> GetSourcesAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetNoteSourcesResponse>("/api/v1/notes/sources", cancellationToken);
}
