
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record AccountListSearchResponse
{
    public string? UserName { get; init; }
    public string? DisplayName { get; init; }
    public SmarterMail.Net.Models.Enums.StatusTypes Status { get; init; }
    public SmarterMail.Net.Models.Enums.AccountTypes AccountType { get; init; }
    public SmarterMail.Net.Models.Enums.UserAuthenticationTypes AuthType { get; init; }
    public bool IsEasEnabled { get; init; }
    public bool IsMapiEwsEnabled { get; init; }
    public JsonElement? LastLogin { get; init; }
    public JsonElement? EasLastLogin { get; init; }
    public JsonElement? MapiLastLogin { get; init; }
    public JsonElement? EwsLastLogin { get; init; }
    public JsonElement? PopLastLogin { get; init; }
    public JsonElement? ImapLastLogin { get; init; }
    public JsonElement? SmtpLastLogin { get; init; }
    public long AliasTargetCount { get; init; }
    public bool AliasIsCatchAll { get; init; }
    public bool AliasIncludeAllDomainUsers { get; init; }
    public bool ShowInGAL { get; init; }
    public long BytesUsed { get; init; }
    public long BytesAllowed { get; init; }
    public int BytesUsedPercent { get; init; }
    public bool AcceptedNewestPolicy { get; init; }
}
