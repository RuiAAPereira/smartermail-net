
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record LicensingInfoResponse
{
    public SmarterMail.Net.Models.Enums.EditionType Edition { get; init; }
    public int MaxUsers { get; init; }
    public int MaxDomains { get; init; }
    public bool EnterpriseFunctionality { get; init; }
    public bool Beta { get; init; }
    public bool IsBeta { get; init; }
    public JsonElement? Stats { get; init; }
    public bool IsLeasedLicense { get; init; }
    public bool IsTrialLicense { get; init; }
    public bool IsHighAvailabilityLicense { get; init; }
    public bool IsActivated { get; init; }
    public JsonElement? Expiration { get; init; }
    public string? LicenseKey { get; init; }
    public JsonElement? UpgradeProtectionExpires { get; init; }
    public JsonElement? BetaExpiration { get; init; }
    public JsonElement? Services { get; init; }
    public bool Enabled { get; init; }
    public bool TrialAvailable { get; init; }
}
