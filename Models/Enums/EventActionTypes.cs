
namespace SmarterMail.Net.Models.Enums;

public enum EventActionTypes
{
    None = 0,
    AlertAction = 1,
    AlertUserAction = 2,
    TrustedSender = 3,
    CommandLineAction = 4,
    DebugPrintAction = 5,
    EmailAction = 6,
    AddRecipientAction = 7,
    WebhookAction = 8,
}
