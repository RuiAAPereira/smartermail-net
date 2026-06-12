
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum RemoveFromJunkOptionType
{
    None = 0,
    AddToTrustedSender = 1,
    RemoveFromBlacklist = 2,
}
