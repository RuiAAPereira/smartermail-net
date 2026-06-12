
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum ThrottlingActions
{
    Reject = 0,
    Delay = 1,
    None = 2,
}
