
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record AccountListSearchQuickResponse
{
    public SmarterMail.Net.Models.Enums.UserAuthenticationTypes AuthenticationType { get; init; }
    public SmarterMail.Net.Models.Enums.AccountTypes AccountType { get; init; }
    public long BytesAllowed { get; init; }
    public long BytesUsed { get; init; }
    public long PrimaryBytes { get; init; }
    public long SecondaryBytes { get; init; }
    public int BytesUsedPercent { get; init; }
    public int SecondaryBytesPercent { get; init; }
    public int PrimaryBytesPercent { get; init; }
    public string? DisplayName { get; init; }
    public string? LastLoginProtocol { get; init; }
    public DateTime? LastLoginTime { get; init; }
    public SmarterMail.Net.Models.Enums.StatusTypes Status { get; init; }
}
