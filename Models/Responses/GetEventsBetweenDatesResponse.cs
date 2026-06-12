#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for <c>POST /api/v1/calendars/events/{owner}/{id}</c> (events between dates).</summary>
public record GetEventsBetweenDatesResponse
{
    public List<CalendarEventInfo>? Events { get; init; }
}
