
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetLicenseNotificationsResponse
{
    public bool IsOverLicenseLimit { get; init; }
    public bool IsFreeEdition { get; init; }
    public bool IsUpgradeProtectionExpired { get; init; }
    public bool IsUpgradeProtectionExpiringSoon { get; init; }
    public int DaysUntilUpgradeProtectionExpires { get; init; }
    public bool IsTrialLicenseExpiringSoon { get; init; }
    public int DaysUntilTrialExpires { get; init; }
    public bool HasMissedCallbacks { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
