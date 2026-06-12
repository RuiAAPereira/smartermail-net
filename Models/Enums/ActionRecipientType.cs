
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum ActionRecipientType
{
    None = 0,
    Users = 1,
    DomainAdmins = 2,
    SystemAdmins = 4,
    SpecifiedUser = 8,
}
