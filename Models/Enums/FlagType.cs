
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum FlagType
{
    None = 0,
    Basic = 1,
    Color = 2,
    Time = 4,
    Complete = 8,
    Recipient = 16,
    Sender = 32,
}
