
namespace SmarterMail.Net.Models.Enums;

public enum MailboxImportItem
{
    None = 0,
    Email = 1,
    Contacts = 2,
    Calendar = 4,
    Tasks = 8,
    Notes = 16,
    All = 31,
}
