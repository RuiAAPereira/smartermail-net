
#nullable enable

using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetAllContactMembersResponse
{
    public List<ContactMemberInfo>? Results { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
