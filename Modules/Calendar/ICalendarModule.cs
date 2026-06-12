#nullable enable

using System.IO;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Calendar;

/// <summary>Operations for the authenticated user's calendar.</summary>
public interface ICalendarModule
{
    /// <summary>Searches for calendar events matching the specified criteria.</summary>
    Task<GetAllEventsFromSearchResponse> GetEventsAsync(GetAllEventsFromSearchRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves full details for a specific calendar event.</summary>
    Task<GetEventDetailsResponse> GetEventAsync(string owner, string calId, string eventId, CancellationToken cancellationToken = default);

    /// <summary>Creates or updates a calendar event.</summary>
    Task<SaveEventResponse> SaveEventAsync(string owner, string calId, string eventId, bool notifyAttendees, SaveEventRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes a calendar event or, when <paramref name="body"/> carries an instanceStart,
    /// a single occurrence of a recurring series. Set notify to true to send cancellation notices.</summary>
    Task<DeleteEventResponse> DeleteEventAsync(string owner, string calId, string eventId, bool notify, DeleteEventBodyRequest? body = null, CancellationToken cancellationToken = default);

    /// <summary>Deletes a received meeting invitation or, when <paramref name="body"/> carries an instanceStart, one occurrence.</summary>
    Task<DeleteEventResponse> DeleteMeetingInviteAsync(string owner, string calId, string eventId, DeleteEventBodyRequest? body = null, CancellationToken cancellationToken = default);

    /// <summary>Retrieves details for a single occurrence of a recurring event series.</summary>
    Task<GetEventDetailsResponse> GetOccurrenceDetailsAsync(string owner, string calId, string eventId, GetOccurrenceDetailsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Accepts a meeting invitation.</summary>
    Task<AcceptMeetingInviteResponse> AcceptInvitationAsync(string owner, string calId, string eventId, string recurrenceId, AcceptMeetingInviteRequest request, CancellationToken cancellationToken = default);

    /// <summary>Declines a meeting invitation.</summary>
    Task<DeclineMeetingInviteResponse> DeclineInvitationAsync(string owner, string calId, string eventId, string recurrenceId, DeclineMeetingInviteRequest request, CancellationToken cancellationToken = default);

    /// <summary>Tentatively accepts a meeting invitation.</summary>
    Task<TentativeAcceptMeetingInviteResponse> TentativeInvitationAsync(string owner, string calId, string eventId, string recurrenceId, TentativeAcceptMeetingInviteRequest request, CancellationToken cancellationToken = default);

    /// <summary>Lists calendar sources (folders) available to the user.</summary>
    Task<GetCalendarSourcesResponse> GetCalendarSourcesAsync(CancellationToken cancellationToken = default);

    /// <summary>Creates a user calendar source.</summary>
    Task<AddUserCalendarResponse> AddUserCalendarAsync(AddUserCalendarRequest request, CancellationToken cancellationToken = default);

    /// <summary>Updates a user calendar source.</summary>
    Task EditUserCalendarAsync(EditUserCalendarRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes a user calendar source.</summary>
    Task DeleteCalendarAsync(string id, string? accountName = null, CancellationToken cancellationToken = default);

    /// <summary>Renames a user calendar source.</summary>
    Task<RenameUserCalendarResponse> RenameUserCalendarAsync(RenameUserCalendarRequest request, CancellationToken cancellationToken = default);

    /// <summary>Lists internet calendar subscriptions.</summary>
    Task<GetInternetCalendarsResponse> GetInternetCalendarsAsync(CancellationToken cancellationToken = default);

    /// <summary>Creates or updates an internet calendar subscription.</summary>
    Task<AddOrEditInternetCalendarResponse> AddOrEditInternetCalendarAsync(AddOrEditInternetCalendarRequest request, CancellationToken cancellationToken = default);

    /// <summary>Deletes an internet calendar subscription.</summary>
    Task<DeleteInternetCalendarResponse> DeleteInternetCalendarAsync(string id, CancellationToken cancellationToken = default);

    /// <summary>Tests an internet calendar URL.</summary>
    Task<TestInternetCalendarResponse> TestInternetCalendarAsync(string url, CancellationToken cancellationToken = default);

    /// <summary>Imports an ICS file into the specified calendar.</summary>
    Task<ImportIcsFileResponse> ImportIcsFileAsync(string owner, string calId, Stream fileContent, string fileName, CancellationToken cancellationToken = default);

    /// <summary>Exports the specified events as an ICS file.</summary>
    Task<byte[]> ExportEventsAsync(IReadOnlyList<string> eventIds, CancellationToken cancellationToken = default);

    /// <summary>Lists appointments for an owner/calendar within a date range.</summary>
    Task<GetEventsBetweenDatesResponse> GetEventsBetweenDatesAsync(string owner, string id, GetEventsBetweenDatesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves free/busy availability for the given users on a given day.</summary>
    Task<GetUserAvailabilityResponse> GetUserAvailabilityAsync(GetUserAvailabilityRequest request, CancellationToken cancellationToken = default);

    /// <summary>Uploads a file under the given attachment GUID so a subsequent event save (with that GUID) binds it.</summary>
    Task<AddAttachmentResponse> AddAttachmentAsync(string attachGuid, string contentId, Stream fileContent, string fileName, CancellationToken cancellationToken = default);

    /// <summary>Downloads a previously bound event attachment from its (absolute) download URL.</summary>
    Task<byte[]> DownloadAttachmentAsync(string downloadUrl, CancellationToken cancellationToken = default);
}
