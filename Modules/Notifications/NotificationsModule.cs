#nullable enable

using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Notifications;

/// <summary>Implements notification operations via the SmarterMail HTTP API.</summary>
public sealed class NotificationsModule : INotificationsModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="NotificationsModule"/>.</summary>
    public NotificationsModule(ISmarterMailHttpClient http) { _http = http; }

    /// <inheritdoc/>
    public Task<ListNotificationsResponse> GetNotificationsAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<ListNotificationsResponse>("/api/v1/notifications/list", cancellationToken);

    /// <inheritdoc/>
    public Task<DismissResponse> DismissNotificationAsync(DismissRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<DismissResponse>("/api/v1/notifications/dismiss", request, cancellationToken);

    /// <inheritdoc/>
    public Task<DismissAllResponse> DismissAllNotificationsAsync(CancellationToken cancellationToken = default)
        => _http.PostAsync<DismissAllResponse>("/api/v1/notifications/dismiss-all", null, cancellationToken);

    /// <inheritdoc/>
    public Task<SnoozeResponse> SnoozeNotificationAsync(SnoozeRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<SnoozeResponse>("/api/v1/notifications/snooze", request, cancellationToken);
}
