#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>Response for <c>GET /api/v1/calendars/sources</c>.</summary>
public record GetCalendarSourcesResponse
{
    public List<CalendarSourceInfo>? Calendars { get; init; }
    public List<CalendarSourceInfo>? Tasks { get; init; }
    public List<CalendarSourceInfo>? Resources { get; init; }
}
