
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum DkimStatus
{
    Pending = 0,
    FailedDnsLookup = 1,
}
