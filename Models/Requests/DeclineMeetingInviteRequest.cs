
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeclineMeetingInviteRequest
{
    public string? MeetingInfoRaw { get; init; }
}
