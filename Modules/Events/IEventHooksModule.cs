#nullable enable

using System.Threading;
using System.Threading.Tasks;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Events;

/// <summary>Operations for the authenticated user's event hooks (events → actions, incl. webhooks).</summary>
public interface IEventHooksModule
{
    /// <summary>Lists the available event templates (incl. possibleActions to clone). POST /api/v1/settings/user-events.</summary>
    Task<GetUserEventsResponse> GetUserEventsAsync(CancellationToken cancellationToken = default);

    /// <summary>Lists the authenticated owner's event hooks, filtered by name. POST /api/v1/settings/event-hooks-by-owner.</summary>
    Task<GetEventHooksByOwnerResponse> GetEventHooksByOwnerAsync(GetEventHooksByOwnerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Creates an event hook (or updates an existing one when IsNew is false and Id is set). POST /api/v1/settings/event-hook.</summary>
    Task<AddEventHookResponse> AddEventHookAsync(AddEventHookRequest request, CancellationToken cancellationToken = default);

    /// <summary>Reads a single event hook by guid. GET /api/v1/settings/event-hook/{guid}.</summary>
    Task<GetEventHookByGuidResponse> GetEventHookByGuidAsync(string guid, CancellationToken cancellationToken = default);

    /// <summary>Deletes one or more event hooks by guid. POST /api/v1/settings/event-hook-delete.</summary>
    Task<RemoveEventHookResponse> RemoveEventHookAsync(RemoveEventHookRequest request, CancellationToken cancellationToken = default);
}
