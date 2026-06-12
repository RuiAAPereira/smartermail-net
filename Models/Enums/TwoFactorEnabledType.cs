
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum TwoFactorEnabledType
{
    disabled = 0,
    offer = 1,
    force = 2,
    domainLocked = 4,
}
