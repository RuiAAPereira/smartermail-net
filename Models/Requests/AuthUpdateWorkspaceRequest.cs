
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AuthUpdateWorkspaceRequest
{
    public string? FullId { get; init; }
    public string? AuthUsername { get; init; }
    public string? AuthPassword { get; init; }
    public string? AuthProtocol { get; init; }
    public string? Title { get; init; }
    public string? Description { get; init; }
    public string? Password { get; init; }
    public bool AllowGuestUsers { get; init; }
    public bool AttendeesCanStart { get; init; }
    public JsonElement? ScheduledStart { get; init; }
    public string? StartTzId { get; init; }
    public JsonElement? ScheduledEnd { get; init; }
    public string? EndTzId { get; init; }
    public int EndMeetingBehavior { get; init; }
    public bool InProcess { get; init; }
    public JsonElement? SecuritySettings { get; init; }
    public SmarterMail.Net.Models.Enums.MeetingPermissionsFlag CanUploadFiles { get; init; }
    public SmarterMail.Net.Models.Enums.MeetingPermissionsFlag CanMuteOthers { get; init; }
    public SmarterMail.Net.Models.Enums.MeetingPermissionsFlag CanMuteOrganizer { get; init; }
    public SmarterMail.Net.Models.Enums.MeetingPermissionsFlag WaitingRoomOnJoin { get; init; }
    public SmarterMail.Net.Models.Enums.MeetingPermissionsFlag CanAdmitFromWaitingRoom { get; init; }
    public SmarterMail.Net.Models.Enums.MeetingPermissionsFlag CanDisableVideoOthers { get; init; }
}
