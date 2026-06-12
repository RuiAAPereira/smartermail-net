
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum CustomRuleMatchTypes
{
    RegEx = 0,
    Wildcard = 1,
    Contains = 2,
}
