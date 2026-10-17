using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Modules.Mail;

/// <summary>Operations for the authenticated user's email mailbox.</summary>
public interface IMailModule
{
    /// <summary>Retrieves all email folders for the authenticated user.</summary>
    Task<ListMailFoldersResponse> GetFoldersAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves all email folders as a normalized hierarchy.
    /// Parent relationships are resolved by <c>folderIdParent</c> first and by path fallback when needed.
    /// </summary>
    Task<IReadOnlyList<MailFolderNode>> GetFoldersTreeAsync(CancellationToken cancellationToken = default);

    /// <summary>Retrieves a paginated list of messages from a folder.</summary>
    Task<GetMessagesResponse> GetMessagesAsync(GetMessagesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves a single message with full content.</summary>
    Task<GetMessageResponse> GetMessageAsync(GetMessageRequest request, CancellationToken cancellationToken = default);

    /// <summary>Sends a new, reply, or forwarded email message.</summary>
    Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, CancellationToken cancellationToken = default);

    /// <summary>Cancels a delayed or scheduled email before it is sent. Moves it back to Drafts unless <c>KeepInFolder</c> is set.</summary>
    Task<UndoMessageResponse> UndoMessageAsync(UndoMessageRequest request, CancellationToken cancellationToken = default);

    /// <summary>Moves one or more messages to a different folder.</summary>
    Task<MoveMessagesResponse> MoveMessagesAsync(MoveMessagesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes one or more messages from a folder.</summary>
    Task<DeleteMessagesResponse> DeleteMessagesAsync(DeleteMessagesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Searches for messages matching specified criteria.</summary>
    Task<SearchMessagesResponse> SearchMessagesAsync(SearchMessagesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Updates flags on one or more messages (read, unread, flagged, etc.).</summary>
    Task<MessagesPatchResponse> MarkMessagesAsync(MessagesPatchRequest request, CancellationToken cancellationToken = default);

/// <summary>Updates the follow-up flag on one or more messages.</summary>
    Task<MessagesPatchResponse> FlagMessagesAsync(MessagesFlagPatchRequest request, CancellationToken cancellationToken = default);

    /// <summary>Assigns or unassigns categories to one or more messages.</summary>
    Task<MessagesCategoryPatchResponse> MessagesCategoryPatchAsync(MessagesCategoryPatchRequest request, CancellationToken cancellationToken = default);

    /// <summary>Permanently removes messages marked for deletion from a folder.</summary>
    Task<PurgeMarkedAsDeletedFolderResponse> PurgeDeletedAsync(PurgeMarkedAsDeletedFolderRequest request, CancellationToken cancellationToken = default);

    /// <summary>Generates temporary download links for message attachments.</summary>
    Task<GenerateAttachmentLinksResponse> GetAttachmentLinksAsync(GenerateAttachmentLinksRequest request, CancellationToken cancellationToken = default);

    /// <summary>Downloads the raw bytes of a single message attachment by part id. Internally fetches a time-limited link, then performs a GET against it.</summary>
    Task<byte[]> DownloadAttachmentAsync(GenerateAttachmentLinksRequest request, string partId, CancellationToken cancellationToken = default);

    /// <summary>Generates inline attachment links for a message.</summary>
    Task<GenerateMessageInlineLinksResponse> GetInlineAttachmentLinksAsync(GenerateMessageInlineLinksRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a message and returns its HTML body with all <c>cid:</c> inline image references
    /// replaced by time-limited URLs. Returns <c>null</c> when the message has no HTML body.
    /// </summary>
    Task<string?> GetHtmlWithInlineImagesAsync(GetMessageRequest request, CancellationToken cancellationToken = default);

    /// <summary>Uploads an attachment for a draft or outgoing message.</summary>
    Task<AddAttachmentResponse> AddAttachmentAsync(string attachGuid, string contentId, Stream fileContent, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Saves a draft via the draft-put endpoint and binds any staged attachments to it.
    /// Takes the draft-specific <see cref="PutDraftRequest"/> contract: it carries the
    /// reconciliation fields (<c>excludeFiles</c>/<c>draftExcludeFiles</c>/<c>originalCidString</c>/…)
    /// the server needs to commit staged uploads to the draft. Sending the send contract
    /// (<see cref="SendMessageRequest"/>) instead silently drops attachments from the saved draft.
    /// Returns the <c>uid</c> of the saved draft.
    /// </summary>
    Task<DraftPutResponse> DraftPutAsync(
        string attachGuid,
        PutDraftRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>Retrieves statistics and information for a specific folder by path.</summary>
    Task<GetFolderInfoResponse> GetFolderStatsAsync(string folder, GetFolderInfoRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves the raw RFC 2822 source of a message.</summary>
    Task<string> GetRawMessageAsync(GetRawMessageRequest request, CancellationToken cancellationToken = default);

    /// <summary>Exports a single message as EML bytes.</summary>
    Task<byte[]> ExportMessageAsync(ExportMessagesRequest request, CancellationToken cancellationToken = default);
}
