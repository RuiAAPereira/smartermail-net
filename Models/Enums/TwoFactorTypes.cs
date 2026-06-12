
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum TwoFactorTypes
{
    disabled = 0,
    email = 1,
    rfc6238 = 2,
}
