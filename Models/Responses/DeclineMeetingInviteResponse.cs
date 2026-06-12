#nullable enable

namespace SmarterMail.Net.Models.Responses;

public record DeclineMeetingInviteResponse
{
    public bool Success { get; init; }
    public string? Message { get; init; }
}
