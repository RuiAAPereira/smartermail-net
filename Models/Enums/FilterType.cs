
namespace SmarterMail.Net.Models.Enums;

public enum FilterType
{
    Bayesian = 0,
    CustomRule = 1,
    Cyren = 2,
    Declude = 3,
    DKIM = 4,
    DomainKeys = 5,
    MessageSniffer = 6,
    NullSender = 7,
    RemoteSpamAssassin = 8,
    ReverseDns = 9,
    SpamAssassin = 10,
    SPF = 11,
    HoneyPot = 12,
    RemoteRspamd = 13,
    CyrenIp = 14,
}
