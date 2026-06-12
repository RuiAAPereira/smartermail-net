
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum SmtpConnectionEncryptionType
{
    None = 0,
    SSL = 1,
    TLS = 2,
}
