
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum InboundDomainVerificationType
{
    WebService = 0,
    SpecifiedDomains = 1,
    AllButSpecifiedDomains = 2,
}
