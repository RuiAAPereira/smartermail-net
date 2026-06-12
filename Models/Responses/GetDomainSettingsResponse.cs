
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetDomainSettingsResponse
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
    public bool SecondaryIsDisabling { get; init; }
    public string? SecondaryPath { get; init; }
    public int SecondaryAgeDays { get; init; }
    public string? Address { get; init; }
    public SmarterMail.Net.Models.Enums.IPAccessDataType DataType { get; init; }
    public string? Description { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
