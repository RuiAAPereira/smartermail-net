
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum DomainLocationType
{
    Local = 0,
    ExternalMX = 1,
    ExternalHostAddress = 2,
}
