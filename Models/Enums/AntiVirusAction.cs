
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum AntiVirusAction
{
    None = 0,
    Delete = 1,
    Quarantine = 2,
}
