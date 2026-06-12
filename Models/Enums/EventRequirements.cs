
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum EventRequirements
{
    None = 0,
    SystemAdmin = 1,
    DomainAdmin = 2,
    Agent = 4,
    User = 8,
    NotSystemAdmin = 16,
    Enterprise = 32,
    SystemAdminEnterprise = 64,
}
