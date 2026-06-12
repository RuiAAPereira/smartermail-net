
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record TentativeAcceptMeetingInviteRequest
{
    public string? MeetingInfoRaw { get; init; }
}
