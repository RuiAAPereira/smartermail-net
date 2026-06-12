
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum PostingPermission
{
    Anyone = 0,
    Subscribers = 1,
    Moderator = 2,
}
