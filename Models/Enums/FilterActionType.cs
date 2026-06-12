
namespace SmarterMail.Net.Models.Enums;

public enum FilterActionType
{
    NoAction = 0,
    Delete = 1,
    Reroute = 2,
    Bounce = 3,
    MoveToFolder = 4,
    AddHeader = 5,
    PrefixSubject = 6,
    Forward = 7,
    Read = 8,
    SetPriority = 9,
    FollowUp = 10,
}
