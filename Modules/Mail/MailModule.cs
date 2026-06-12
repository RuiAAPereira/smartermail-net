using System.Text.RegularExpressions;
using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Modules.Mail;

/// <summary>Implements email mailbox operations via the SmarterMail HTTP API.</summary>
public sealed class MailModule : IMailModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="MailModule"/>.</summary>
    public MailModule(ISmarterMailHttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc/>
    public Task<ListMailFoldersResponse> GetFoldersAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<ListMailFoldersResponse>("/api/v1/folders/list-email-folders", cancellationToken);

    /// <inheritdoc/>
    public async Task<IReadOnlyList<MailFolderNode>> GetFoldersTreeAsync(CancellationToken cancellationToken = default)
    {
        var response = await GetFoldersAsync(cancellationToken).ConfigureAwait(false);
        if (response.FolderList is null || response.FolderList.Count == 0)
            return Array.Empty<MailFolderNode>();

        var flattened = new List<MailFolderNode>();
        foreach (var folder in response.FolderList)
            CollectFolders(folder, flattened);

        if (flattened.Count == 0)
            return Array.Empty<MailFolderNode>();

        var uniqueByKey = new Dictionary<string, MailFolderNode>(StringComparer.Ordinal);
        var orderedKeys = new List<string>();
        var keyByPath = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        foreach (var folder in flattened)
        {
            var key = GetFolderKey(folder);
            if (!uniqueByKey.ContainsKey(key))
            {
                uniqueByKey[key] = folder;
                orderedKeys.Add(key);
            }

            if (!string.IsNullOrWhiteSpace(folder.Path) && !keyByPath.ContainsKey(folder.Path))
                keyByPath[folder.Path] = key;
        }

        var childrenByParentKey = new Dictionary<string, List<string>>(StringComparer.Ordinal);
        var rootKeys = new List<string>();

        foreach (var key in orderedKeys)
        {
            var folder = uniqueByKey[key];
            var parentKey = ResolveParentKey(folder, uniqueByKey, keyByPath);
            if (parentKey is null || string.Equals(parentKey, key, StringComparison.Ordinal))
            {
                rootKeys.Add(key);
                continue;
            }

            if (!childrenByParentKey.TryGetValue(parentKey, out var children))
            {
                children = [];
                childrenByParentKey[parentKey] = children;
            }

            children.Add(key);
        }

        return rootKeys
            .Select(rootKey => BuildTree(rootKey, uniqueByKey, childrenByParentKey, new HashSet<string>(StringComparer.Ordinal)))
            .ToList();
    }

    /// <inheritdoc/>
    public Task<GetMessagesResponse> GetMessagesAsync(GetMessagesRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetMessagesResponse>("/api/v1/mail/messages", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetMessageResponse> GetMessageAsync(GetMessageRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetMessageResponse>("/api/v1/mail/message/full", request, cancellationToken);

    /// <inheritdoc/>
    public Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<SendMessageResponse>("/api/v1/mail/message-put", request, cancellationToken);

    /// <inheritdoc/>
    public Task<UndoMessageResponse> UndoMessageAsync(UndoMessageRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<UndoMessageResponse>("/api/v1/mail/message-undo", request, cancellationToken);

    /// <inheritdoc/>
    public Task<MoveMessagesResponse> MoveMessagesAsync(MoveMessagesRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<MoveMessagesResponse>("/api/v1/mail/move-messages", request, cancellationToken);

    /// <inheritdoc/>
    public Task<DeleteMessagesResponse> DeleteMessagesAsync(DeleteMessagesRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<DeleteMessagesResponse>("/api/v1/mail/delete-messages", request, cancellationToken);

    /// <inheritdoc/>
    public Task<SearchMessagesResponse> SearchMessagesAsync(SearchMessagesRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<SearchMessagesResponse>("/api/v1/mail/search", request, cancellationToken);

    /// <inheritdoc/>
    public Task<MessagesPatchResponse> MarkMessagesAsync(MessagesPatchRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<MessagesPatchResponse>("/api/v1/mail/messages-patch", request, cancellationToken);

    /// <inheritdoc/>
    public Task<MessagesPatchResponse> FlagMessagesAsync(MessagesFlagPatchRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<MessagesPatchResponse>("/api/v1/mail/messages-flag-patch", request, cancellationToken);

    /// <inheritdoc/>
    public Task<MessagesCategoryPatchResponse> MessagesCategoryPatchAsync(MessagesCategoryPatchRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<MessagesCategoryPatchResponse>("/api/v1/mail/messages-category-patch", request, cancellationToken);

    /// <inheritdoc/>
    public Task<PurgeMarkedAsDeletedFolderResponse> PurgeDeletedAsync(PurgeMarkedAsDeletedFolderRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<PurgeMarkedAsDeletedFolderResponse>("/api/v1/mail/purge-marked-deleted", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GenerateAttachmentLinksResponse> GetAttachmentLinksAsync(GenerateAttachmentLinksRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GenerateAttachmentLinksResponse>("/api/v1/mail/attachment-links", request, cancellationToken);

    /// <inheritdoc/>
    public async Task<byte[]> DownloadAttachmentAsync(GenerateAttachmentLinksRequest request, string partId, CancellationToken cancellationToken = default)
    {
        var response = await GetAttachmentLinksAsync(request, cancellationToken).ConfigureAwait(false);
        if (response.Links is null || !response.Links.TryGetValue(partId, out var info) || string.IsNullOrEmpty(info.Link))
            throw new Exceptions.SmarterMailApiException(404, $"Attachment link not available for partId '{partId}'.");
        return await _http.GetBytesAsync(info.Link!, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<GenerateMessageInlineLinksResponse> GetInlineAttachmentLinksAsync(GenerateMessageInlineLinksRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GenerateMessageInlineLinksResponse>("/api/v1/mail/message-inline-links", request, cancellationToken);

    /// <inheritdoc/>
    public async Task<string?> GetHtmlWithInlineImagesAsync(GetMessageRequest request, CancellationToken cancellationToken = default)
    {
        var message = await GetMessageAsync(request, cancellationToken).ConfigureAwait(false);

        // The API nests all message content under the "messageData" object.
        var html = message.MessageData?.MessageHTML;

        if (string.IsNullOrEmpty(html))
            return null;

        GenerateMessageInlineLinksResponse linksResponse;
        try
        {
            var inlineLinksRequest = new GenerateMessageInlineLinksRequest
            {
                OwnerEmailAddress = request.OwnerEmailAddress,
                Folder = request.Folder,
                Uid = request.Uid
            };
            linksResponse = await GetInlineAttachmentLinksAsync(inlineLinksRequest, cancellationToken).ConfigureAwait(false);
        }
        catch (Exceptions.SmarterMailApiException ex) when (ex.StatusCode == 404)
        {
            // Endpoint not supported on this server version — return HTML with cid: refs intact.
            return html;
        }

        if (linksResponse.InlineLinks is not { Count: > 0 } inlineLinks)
            return html;

        foreach (var kvp in inlineLinks)
        {
            if (string.IsNullOrEmpty(kvp.Value.Link))
                continue;

            html = Regex.Replace(
                html,
                $@"cid:{Regex.Escape(kvp.Key)}",
                kvp.Value.Link,
                RegexOptions.IgnoreCase);
        }

        return html;
    }

    /// <inheritdoc/>
    public Task<AddAttachmentResponse> AddAttachmentAsync(string attachGuid, string contentId, Stream fileContent, string fileName, CancellationToken cancellationToken = default)
        => _http.PostResumableAttachmentAsync<AddAttachmentResponse>(attachGuid, fileContent, fileName, cancellationToken);

    /// <inheritdoc/>
    public Task<DraftPutResponse> DraftPutAsync(
        string attachGuid,
        SendMessageRequest request,
        CancellationToken cancellationToken = default)
        => _http.PostAsync<DraftPutResponse>(
            $"/api/v1/mail/draft-put/{Uri.EscapeDataString(attachGuid)}",
            request,
            cancellationToken);

    /// <inheritdoc/>
    public Task<GetFolderInfoResponse> GetFolderStatsAsync(string folder, GetFolderInfoRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetFolderInfoResponse>($"/api/v1/settings/get-folder-info/{Uri.EscapeDataString(folder)}", request, cancellationToken);

    /// <inheritdoc/>
    public Task<string> GetRawMessageAsync(GetRawMessageRequest request, CancellationToken cancellationToken = default)
        => _http.PostStringAsync("/api/v1/mail/message/raw", request, cancellationToken);

    /// <inheritdoc/>
    public Task<byte[]> ExportMessageAsync(ExportMessagesRequest request, CancellationToken cancellationToken = default)
        => _http.PostBytesAsync("/api/v1/mail/messages-export", request, cancellationToken);

    private static void CollectFolders(MailFolderInfo folder, List<MailFolderNode> destination)
    {
        destination.Add(MapFolder(folder));

        if (folder.SubFolders is { Count: > 0 })
        {
            foreach (var child in folder.SubFolders)
                CollectFolders(child, destination);
        }
    }

    private static MailFolderNode MapFolder(MailFolderInfo folder) => new()
    {
        Id = folder.Id,
        ParentFolderId = folder.FolderIdParent == 0 ? null : folder.FolderIdParent,
        Name = folder.Name ?? "",
        Path = folder.Path ?? "",
        Unread = folder.Unread,
        TotalMessages = folder.TotalMessages,
        Size = folder.Size,
        CanDelete = folder.CanDelete,
        CanEdit = folder.CanEdit,
        SubFolders = Array.Empty<MailFolderNode>(),
    };

    private static string GetFolderKey(MailFolderNode folder) =>
        folder.Id > 0
            ? $"id:{folder.Id}"
            : $"path:{folder.Path}";

    private static string? ResolveParentKey(
        MailFolderNode folder,
        IReadOnlyDictionary<string, MailFolderNode> uniqueByKey,
        IReadOnlyDictionary<string, string> keyByPath)
    {
        if (folder.ParentFolderId is long parentId && parentId > 0)
        {
            var byId = $"id:{parentId}";
            if (uniqueByKey.ContainsKey(byId))
                return byId;
        }

        if (!string.IsNullOrWhiteSpace(folder.Path))
        {
            var slash = folder.Path.LastIndexOf('/');
            if (slash > 0)
            {
                var parentPath = folder.Path.Substring(0, slash);
                if (keyByPath.TryGetValue(parentPath, out var parentKey))
                    return parentKey;
            }
        }

        return null;
    }

    private static MailFolderNode BuildTree(
        string key,
        IReadOnlyDictionary<string, MailFolderNode> uniqueByKey,
        IReadOnlyDictionary<string, List<string>> childrenByParentKey,
        HashSet<string> visiting)
    {
        if (!uniqueByKey.TryGetValue(key, out var folder))
            return new MailFolderNode();

        if (!visiting.Add(key))
            return folder;

        IReadOnlyList<MailFolderNode> children = Array.Empty<MailFolderNode>();
        if (childrenByParentKey.TryGetValue(key, out var childKeys) && childKeys.Count > 0)
        {
            children = childKeys
                .Select(childKey => BuildTree(childKey, uniqueByKey, childrenByParentKey, visiting))
                .ToList();
        }

        visiting.Remove(key);
        return folder with { SubFolders = children };
    }
}
