#nullable enable

using System.Collections.Generic;
using System.IO;
using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Modules.Calendar;

/// <summary>Implements calendar operations via the SmarterMail HTTP API.</summary>
public sealed class CalendarModule : ICalendarModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="CalendarModule"/>.</summary>
    public CalendarModule(ISmarterMailHttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc/>
    public Task<GetAllEventsFromSearchResponse> GetEventsAsync(GetAllEventsFromSearchRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetAllEventsFromSearchResponse>("/api/v1/calendars/events-all2", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetEventDetailsResponse> GetEventAsync(string owner, string calId, string eventId, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetEventDetailsResponse>(
            $"/api/v1/calendars/events/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}/{Uri.EscapeDataString(eventId)}",
            cancellationToken);

    /// <inheritdoc/>
    public Task<SaveEventResponse> SaveEventAsync(string owner, string calId, string eventId, bool notifyAttendees, SaveEventRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<SaveEventResponse>(
            $"/api/v1/calendars/events/save/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}/{Uri.EscapeDataString(eventId)}/{notifyAttendees.ToString().ToLowerInvariant()}",
            request, cancellationToken);

    /// <inheritdoc/>
    public async Task<DeleteEventResponse> DeleteEventAsync(string owner, string calId, string eventId, bool notify, DeleteEventBodyRequest? body = null, CancellationToken cancellationToken = default)
    {
        await _http.PostAsync<System.Text.Json.JsonElement>(
            $"/api/v1/calendars/events/delete/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}/{Uri.EscapeDataString(eventId)}/{notify.ToString().ToLowerInvariant()}",
            body, cancellationToken).ConfigureAwait(false);

        return new DeleteEventResponse
        {
            Owner = owner,
            CalendarId = calId,
            EventId = eventId,
            InstanceStart = body?.InstanceStart,
        };
    }

    /// <inheritdoc/>
    public async Task<DeleteEventResponse> DeleteMeetingInviteAsync(string owner, string calId, string eventId, DeleteEventBodyRequest? body = null, CancellationToken cancellationToken = default)
    {
        await _http.PostAsync<System.Text.Json.JsonElement>(
            $"/api/v1/calendars/meeting-delete/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}/{Uri.EscapeDataString(eventId)}",
            body, cancellationToken).ConfigureAwait(false);

        return new DeleteEventResponse
        {
            Owner = owner,
            CalendarId = calId,
            EventId = eventId,
            InstanceStart = body?.InstanceStart,
        };
    }

    /// <inheritdoc/>
    public Task<GetEventDetailsResponse> GetOccurrenceDetailsAsync(string owner, string calId, string eventId, GetOccurrenceDetailsRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetEventDetailsResponse>(
            $"/api/v1/calendars/events/occurrence/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}/{Uri.EscapeDataString(eventId)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<AcceptMeetingInviteResponse> AcceptInvitationAsync(string owner, string calId, string eventId, string recurrenceId, AcceptMeetingInviteRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AcceptMeetingInviteResponse>(
            $"/api/v1/calendars/meeting-accept/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}/{Uri.EscapeDataString(eventId)}/{Uri.EscapeDataString(recurrenceId)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<DeclineMeetingInviteResponse> DeclineInvitationAsync(string owner, string calId, string eventId, string recurrenceId, DeclineMeetingInviteRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<DeclineMeetingInviteResponse>(
            $"/api/v1/calendars/meeting-decline/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}/{Uri.EscapeDataString(eventId)}/{Uri.EscapeDataString(recurrenceId)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<TentativeAcceptMeetingInviteResponse> TentativeInvitationAsync(string owner, string calId, string eventId, string recurrenceId, TentativeAcceptMeetingInviteRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<TentativeAcceptMeetingInviteResponse>(
            $"/api/v1/calendars/meeting-tentatively-accept/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}/{Uri.EscapeDataString(eventId)}/{Uri.EscapeDataString(recurrenceId)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetCalendarSourcesResponse> GetCalendarSourcesAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetCalendarSourcesResponse>("/api/v1/calendars/sources", cancellationToken);

    /// <inheritdoc/>
    public Task<AddUserCalendarResponse> AddUserCalendarAsync(AddUserCalendarRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddUserCalendarResponse>("/api/v1/calendars/calendar-put", new { setting = request }, cancellationToken);

    /// <inheritdoc/>
    public async Task EditUserCalendarAsync(EditUserCalendarRequest request, CancellationToken cancellationToken = default)
        => await _http.PostAsync("/api/v1/calendars/calendar", new { setting = request }, cancellationToken).ConfigureAwait(false);

    /// <inheritdoc/>
    public async Task DeleteCalendarAsync(string id, string? accountName = null, CancellationToken cancellationToken = default)
    {
        var path = $"/api/v1/calendars/calendar-delete/{Uri.EscapeDataString(id)}";
        if (!string.IsNullOrWhiteSpace(accountName))
            path += $"/{Uri.EscapeDataString(accountName!)}";
        await _http.PostAsync(path, null, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<RenameUserCalendarResponse> RenameUserCalendarAsync(RenameUserCalendarRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<RenameUserCalendarResponse>("/api/v1/calendars/rename", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetInternetCalendarsResponse> GetInternetCalendarsAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetInternetCalendarsResponse>("/api/v1/calendars/internet-calendars", cancellationToken);

    /// <inheritdoc/>
    public Task<AddOrEditInternetCalendarResponse> AddOrEditInternetCalendarAsync(AddOrEditInternetCalendarRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<AddOrEditInternetCalendarResponse>("/api/v1/calendars/internet-calendars-put", request, cancellationToken);

    /// <inheritdoc/>
    public Task<DeleteInternetCalendarResponse> DeleteInternetCalendarAsync(string id, CancellationToken cancellationToken = default)
        => _http.PostAsync<DeleteInternetCalendarResponse>(
            $"/api/v1/calendars/internet-calendars-delete/{Uri.EscapeDataString(id)}", null, cancellationToken);

    /// <inheritdoc/>
    public Task<TestInternetCalendarResponse> TestInternetCalendarAsync(string url, CancellationToken cancellationToken = default)
        => _http.PostAsync<TestInternetCalendarResponse>("/api/v1/calendars/internet-calendars-test", url, cancellationToken);

    /// <inheritdoc/>
    public Task<ImportIcsFileResponse> ImportIcsFileAsync(string owner, string calId, Stream fileContent, string fileName, CancellationToken cancellationToken = default)
        => _http.PostMultipartAsync<ImportIcsFileResponse>(
            $"/api/v1/calendars/import-ics/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(calId)}",
            fileContent, fileName, cancellationToken);

    /// <inheritdoc/>
    public Task<byte[]> ExportEventsAsync(IReadOnlyList<string> eventIds, CancellationToken cancellationToken = default)
        => _http.PostBytesAsync("/api/v1/calendars/export/download", eventIds, cancellationToken);

    /// <inheritdoc/>
    public Task<GetEventsBetweenDatesResponse> GetEventsBetweenDatesAsync(string owner, string id, GetEventsBetweenDatesRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<GetEventsBetweenDatesResponse>(
            $"/api/v1/calendars/events/{Uri.EscapeDataString(owner)}/{Uri.EscapeDataString(id)}",
            request, cancellationToken);

    /// <inheritdoc/>
    public async Task<GetUserAvailabilityResponse> GetUserAvailabilityAsync(GetUserAvailabilityRequest request, CancellationToken cancellationToken = default)
    {
        var users = await _http.PostAsync<List<UserAvailability>>(
            "/api/v1/calendars/user-availability", request, cancellationToken).ConfigureAwait(false);
        return new GetUserAvailabilityResponse { Users = users ?? new() };
    }

    /// <inheritdoc/>
    // contentId accepted for signature symmetry with MailModule; the resumable uploader does not take it.
    public Task<AddAttachmentResponse> AddAttachmentAsync(string attachGuid, string contentId, Stream fileContent, string fileName, CancellationToken cancellationToken = default)
        => _http.PostResumableAttachmentAsync<AddAttachmentResponse>(attachGuid, fileContent, fileName, cancellationToken);

    /// <inheritdoc/>
    public Task<byte[]> DownloadAttachmentAsync(string downloadUrl, CancellationToken cancellationToken = default)
        => _http.GetBytesAsync(downloadUrl, cancellationToken);
}
