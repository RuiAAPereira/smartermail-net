
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ProposeNewMeetingTimeRequest
{
    public JsonElement? DtStart { get; init; }
    public JsonElement? DtEnd { get; init; }
    public string? ReplyStatus { get; init; }
    public string? Timezone { get; init; }
    public string? MeetingInfoRaw { get; init; }
}
