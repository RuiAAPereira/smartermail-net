
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum AppendReceivedOption
{
    AllIncomingMessages = 0,
    None = 1,
    NonAuthenticatedMessages = 2,
}
