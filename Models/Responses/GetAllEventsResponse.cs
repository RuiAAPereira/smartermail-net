#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for <c>GET /api/v1/calendars/events-all/{owner}/{id}</c>.</summary>
public record GetAllEventsResponse
{
    public List<CalendarEventInfo>? Events { get; init; }
}
