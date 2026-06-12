
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum InternalSpamCheckBehaviorType
{
    BYPASS_SPAM_CHECKS = 0,
    CHECK_ALL_MESSAGES = 1,
    CHECK_OTHER_DOMAINS = 2,
}
