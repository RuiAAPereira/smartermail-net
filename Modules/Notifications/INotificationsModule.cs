#nullable enable

using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Notifications;

/// <summary>Operations for the authenticated user's notifications and alerts.</summary>
public interface INotificationsModule
{
    /// <summary>Retrieves the list of active notifications for the current user.</summary>
    Task<ListNotificationsResponse> GetNotificationsAsync(CancellationToken cancellationToken = default);

    /// <summary>Dismisses one or more notifications by ID.</summary>
    Task<DismissResponse> DismissNotificationAsync(DismissRequest request, CancellationToken cancellationToken = default);

    /// <summary>Dismisses all active notifications for the current user.</summary>
    Task<DismissAllResponse> DismissAllNotificationsAsync(CancellationToken cancellationToken = default);

    /// <summary>Snoozes one or more notifications by ID.</summary>
    Task<SnoozeResponse> SnoozeNotificationAsync(SnoozeRequest request, CancellationToken cancellationToken = default);
}
