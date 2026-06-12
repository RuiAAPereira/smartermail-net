
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetAliasByNameResponse
{
    public string? Name { get; init; }
    public string? DisplayName { get; init; }
    public JsonElement? AliasTargetList { get; init; }
    public bool HideFromGAL { get; init; }
    public bool BypassGreylist { get; init; }
    public DateTime? CreationDate { get; init; }
    public bool EnableForXmpp { get; init; }
    public bool InternalOnly { get; init; }
    public bool IncludeAllDomainUsers { get; init; }
    public bool IsDisposable { get; init; }
    public DateTime? DisposeExpireTime { get; init; }
    public string? Folder { get; init; }
    public bool AllowSending { get; init; }
    public bool IsCatchAll { get; init; }
    public string? Description { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
