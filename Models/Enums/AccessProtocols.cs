
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum AccessProtocols
{
    Undefined = 0,
    IMAP = 1,
    POP = 2,
    XMPP = 4,
    SMTP = 8,
    GREYLIST_LEGACY = 16,
    LDAP = 32,
    MAPI_EWS = 64,
    WEBDAV = 128,
    WEBMAIL = 256,
    ACTIVE_SYNC = 512,
}
