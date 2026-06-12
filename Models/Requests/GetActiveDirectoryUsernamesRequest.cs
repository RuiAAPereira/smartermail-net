
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetActiveDirectoryUsernamesRequest
{
    public string? LdapProviderId { get; init; }
    public string? LdapUsername { get; init; }
    public string? LdapPassword { get; init; }
}
