
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DownloadMeetingFileRequest
{
    public string? MeetingID { get; init; }
}
