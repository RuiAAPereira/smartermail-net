
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum JunkOptionType
{
    MoveToJunkFolder = 0,
    MoveToJunkBlacklistEmail = 1,
    MoveToJunkBlacklistDomain = 2,
}
