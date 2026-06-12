#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Shared;

/// <summary>An attendee or resource invited to a calendar event.</summary>
public record EventAttendee
{
    public string? Name { get; init; }
    public string? Email { get; init; }
    /// <summary>Attendance status int (accepted/declined/tentative/needs-action). Values are not
    /// documented by the API; see MyMail.Features.Calendar.Internal.AttendeeWire for the mapping.</summary>
    public int Status { get; init; }
    public bool Conflict { get; init; }
    /// <summary>Per-hour non-availability flags for the event day.</summary>
    public IReadOnlyList<bool>? Nonavail { get; init; }
    public bool IsOrganizer { get; init; }
    public bool IsResource { get; init; }
    public int ResourceType { get; init; }
}
