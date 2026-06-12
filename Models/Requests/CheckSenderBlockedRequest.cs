
#nullable enable

namespace SmarterMail.Net.Models.Requests;

public record CheckSenderBlockedRequest
{
    public string? Email { get; init; }
}
