
namespace SmarterMail.Net.Models.Enums;

public enum RoutingRuleActionType
{
    NoAction = 0,
    DeleteMessage = 1,
    SendToGateway = 2,
    Quarantine = 3,
    AddHeader = 4,
    PrefixSubject = 5,
    Bounce = 6,
    StripAttachments = 7,
    StopProcessingRules = 8,
    AddRecipient = 9,
    SendCopy = 10,
    ShowNotification = 11,
    SendEmail = 12,
    CommandLineAction = 13,
    SendWebhook = 14,
}
