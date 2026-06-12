#nullable enable

using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models;

public record SignatureMap
{
    public bool AllowUsersToOverride { get; init; }
    public string? Key { get; init; }
    public SignatureMapOption MapOption { get; init; }
    public string? SignatureGuid { get; init; }
    public SignatureMapType Type { get; init; }
}
