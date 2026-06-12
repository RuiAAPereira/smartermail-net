#nullable enable

namespace SmarterMail.Net.Models.Responses;

public record AcceptMeetingInviteResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
}
