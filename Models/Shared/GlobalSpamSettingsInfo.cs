// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "settings" sub-object returned by the global spam settings endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record GlobalSpamSettingsInfo
{
    public bool AllowBouncesForOutgoingBlockedItems { get; init; }
    public bool AllowSystemResponsesToCatchallMessages { get; init; }
    public bool EnableDmarcPolicy { get; init; }
    public int DmarcQuarantineWeight { get; init; }
    public DmarcPolicyType DmarcFallbackPolicy { get; init; }
    public bool ProviderReportSpamHam { get; init; }
    public bool CopySpamHamToFolders { get; init; }
    public int SpamCheckTimeOut { get; init; }
    public InternalSpamCheckBehaviorType InternalSpamCheckBehavior { get; init; }
    public long MaxMessageSizeToContentScan { get; init; }
    public int MaxSpamThreads { get; init; }
    public bool SkipSpamChecksForSmtpWhiteListedIps { get; init; }
    public bool AllowDomainOverride { get; init; }
    public bool AllowUserOverride { get; init; }
    public bool OutgoingBlockingEnabled { get; init; }
    public int OutgoingBlockingThreshold { get; init; }
    public bool OutgoingQuarantineEnabled { get; init; }
    public AntiSpamOutboundAction OutgoingQuarantineAction { get; init; }
    public bool IncomingBlockingEnabled { get; init; }
    public int IncomingBlockThreshold { get; init; }
    public bool UseSpoolProcFolder { get; init; }
    public AutoResponseRestrictionLevel AutoResponseRestrictionLevel { get; init; }
    public ContentFilterBounceRestrictionLevel ContentFilterBounceRestrictionLevel { get; init; }
    public JsonElement? SpamLevelLow { get; init; }
    public JsonElement? SpamLevelMedium { get; init; }
    public JsonElement? SpamLevelHigh { get; init; }
}
