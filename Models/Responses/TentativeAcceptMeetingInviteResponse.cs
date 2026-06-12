#nullable enable

namespace SmarterMail.Net.Models.Responses;

public record TentativeAcceptMeetingInviteResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
}
