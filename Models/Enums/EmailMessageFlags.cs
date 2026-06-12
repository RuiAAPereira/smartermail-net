
namespace SmarterMail.Net.Models.Enums;

public enum EmailMessageFlags
{
    Read = 0,
    Replied = 1,
    Forwarded = 2,
    Deleted = 3,
    Flagged = 4,
    Draft = 5,
    Recent = 6,
    hasAttachment = 7,
    linkedToTask = 8,
}
