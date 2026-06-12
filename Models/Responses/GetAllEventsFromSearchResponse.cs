// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System;
using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetAllEventsFromSearchResponse
{
    public long TotalCount { get; init; }
    public JsonElement? Results { get; init; }
    public long Id { get; init; }
    public string? Uid { get; init; }
    public string? Title { get; init; }
    public bool AllDay { get; init; }
    public JsonElement? StartWithTZ { get; init; }
    public JsonElement? EndWithTZ { get; init; }
    public bool Editable { get; init; }
    public string? Owner { get; init; }
    public string? CalId { get; init; }
    public string? CalName { get; init; }
    public string? Location { get; init; }
    public bool IsRecurring { get; init; }
    public bool IsTentative { get; init; }
    public bool IsOnlineMeeting { get; init; }
    public bool IsPrivate { get; init; }
    public SmarterMail.Net.Models.Enums.EventStatus Status { get; init; }
    public string? ResourceId { get; init; }
    public DateTime? NextRecurrenceUtc { get; init; }
    public int FirstReminder { get; init; }
    public bool IsTask { get; init; }
    public bool IsTaskComplete { get; init; }
    public bool AllowReplies { get; init; }
    public JsonElement? Categories { get; init; }
    public string? Name { get; init; }
    public bool Master { get; init; }
    public OrganizerInfo? Organizer { get; init; }
    public string? ReservedBy { get; init; }
    public OrgCalInfo? OrgCalInfo { get; init; }
    public long AttendeeCount { get; init; }
    public long ResourceCount { get; init; }
    public SmarterMail.Net.Models.Enums.ShareAccess Permission { get; init; }
    public JsonElement? OccurrenceId { get; init; }
    public bool HasAttachments { get; init; }
}
