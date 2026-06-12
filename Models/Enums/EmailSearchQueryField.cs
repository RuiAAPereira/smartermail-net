
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum EmailSearchQueryField
{
    None = 0,
    From = 1,
    To = 2,
    Subject = 4,
    Body = 8,
    Date = 16,
    Cc = 32,
    Header = 64,
    Uid = 128,
    Bcc = 256,
}
