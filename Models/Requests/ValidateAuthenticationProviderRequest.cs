
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ValidateAuthenticationProviderRequest
{
    public string? ProviderId { get; init; }
    public string? ProviderName { get; init; }
    public SmarterMail.Net.Models.Enums.AuthenticationType ProviderType { get; init; }
    public string? LdapUsername { get; init; }
    public string? LdapPassword { get; init; }
    public string? ServerName { get; init; }
    public int ServerPort { get; init; }
    public SmarterMail.Net.Models.Enums.EncryptionType Encryption { get; init; }
    public string? LdapBaseDn { get; init; }
    public string? Fqdn { get; init; }
    public string? OrganizationalUnit { get; init; }
    public bool SaveCredentials { get; init; }
}
