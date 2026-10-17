#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;
using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Events;

/// <summary>Implements event-hook operations via the SmarterMail HTTP API.</summary>
public sealed class EventHooksModule : IEventHooksModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="EventHooksModule"/>.</summary>
    public EventHooksModule(ISmarterMailHttpClient http) { _http = http; }

    /// <inheritdoc/>
    public Task<GetUserEventsResponse> GetUserEventsAsync(CancellationToken cancellationToken = default)
        => _http.PostAsync<GetUserEventsResponse>("/api/v1/settings/user-events", new { }, cancellationToken);

    /// <inheritdoc/>
    public Task<GetEventHooksByOwnerResponse> GetEventHooksByOwnerAsync(GetEventHooksByOwnerRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetEventHooksByOwnerResponse>("/api/v1/settings/event-hooks-by-owner", request, cancellationToken);

    /// <inheritdoc/>
    public Task<AddEventHookResponse> AddEventHookAsync(AddEventHookRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddEventHookResponse>("/api/v1/settings/event-hook", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetEventHookByGuidResponse> GetEventHookByGuidAsync(string guid, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetEventHookByGuidResponse>(
            $"/api/v1/settings/event-hook/{Uri.EscapeDataString(guid)}", cancellationToken);

    /// <inheritdoc/>
    public Task<RemoveEventHookResponse> RemoveEventHookAsync(RemoveEventHookRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<RemoveEventHookResponse>("/api/v1/settings/event-hook-delete", request, cancellationToken);
}
