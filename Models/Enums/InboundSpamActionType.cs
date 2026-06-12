
namespace SmarterMail.Net.Models.Enums;

public enum InboundSpamActionType
{
    None = 0,
    Subject = 1,
    Header = 2,
    Reroute = 3,
    Delete = 4,
    PassScore = 5,
}
