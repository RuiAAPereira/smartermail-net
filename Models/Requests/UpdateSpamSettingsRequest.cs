
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UpdateSpamSettingsRequest
{
    public bool AllowBouncesForOutgoingBlockedItems { get; init; }
    public bool AllowSystemResponsesToCatchallMessages { get; init; }
    public bool EnableDmarcPolicy { get; init; }
    public int DmarcQuarantineWeight { get; init; }
    public SmarterMail.Net.Models.Enums.DmarcPolicyType DmarcFallbackPolicy { get; init; }
    public bool ProviderReportSpamHam { get; init; }
    public bool CopySpamHamToFolders { get; init; }
    public int SpamCheckTimeOut { get; init; }
    public SmarterMail.Net.Models.Enums.InternalSpamCheckBehaviorType InternalSpamCheckBehavior { get; init; }
    public long MaxMessageSizeToContentScan { get; init; }
    public int MaxSpamThreads { get; init; }
    public bool SkipSpamChecksForSmtpWhiteListedIps { get; init; }
    public bool AllowDomainOverride { get; init; }
    public bool AllowUserOverride { get; init; }
    public bool OutgoingBlockingEnabled { get; init; }
    public int OutgoingBlockingThreshold { get; init; }
    public bool OutgoingQuarantineEnabled { get; init; }
    public SmarterMail.Net.Models.Enums.AntiSpamOutboundAction OutgoingQuarantineAction { get; init; }
    public bool IncomingBlockingEnabled { get; init; }
    public int IncomingBlockThreshold { get; init; }
    public bool UseSpoolProcFolder { get; init; }
    public SmarterMail.Net.Models.Enums.AutoResponseRestrictionLevel AutoResponseRestrictionLevel { get; init; }
    public SmarterMail.Net.Models.Enums.ContentFilterBounceRestrictionLevel ContentFilterBounceRestrictionLevel { get; init; }
    public JsonElement? SpamLevelLow { get; init; }
    public JsonElement? SpamLevelMedium { get; init; }
    public JsonElement? SpamLevelHigh { get; init; }
    public JsonElement? Cyren { get; init; }
    public JsonElement? CyrenIp { get; init; }
    public JsonElement? Declude { get; init; }
    public JsonElement? Dkim { get; init; }
    public JsonElement? Greylisting { get; init; }
    public JsonElement? MessageSniffer { get; init; }
    public JsonElement? ReverseDns { get; init; }
    public JsonElement? NullSender { get; init; }
    public JsonElement? SpamAssassin { get; init; }
    public JsonElement? RemoteSpamAssassin { get; init; }
    public JsonElement? RemoteRspamd { get; init; }
    public JsonElement? Spf { get; init; }
    public JsonElement? HoneyPot { get; init; }
    public JsonElement? Dmarc { get; init; }
    public JsonElement? PrivateSuffixList { get; init; }
}
