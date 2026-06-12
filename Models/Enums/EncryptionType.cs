
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum EncryptionType
{
    None = 0,
    SslTls = 1,
    NegotiateTls = 2,
}
