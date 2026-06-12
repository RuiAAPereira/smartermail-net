
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum InboundUserVerificationType
{
    None = 0,
    WebService = 1,
    SMTP = 2,
}
