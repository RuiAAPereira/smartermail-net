
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum SmtpBlockRuleType
{
    EmailAddress = 0,
    EhloDomain = 1,
}
