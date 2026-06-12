
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum ThrottleType
{
    MessagesOut = 0,
    Bandwidth = 1,
    BouncesReceived = 2,
}
