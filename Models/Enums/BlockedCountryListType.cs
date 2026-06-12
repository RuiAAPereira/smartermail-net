
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum BlockedCountryListType
{
    None = 0,
    Blocked = 1,
    Unblocked = 2,
    Global = 4,
}
