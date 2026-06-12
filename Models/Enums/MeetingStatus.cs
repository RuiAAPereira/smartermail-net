
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum MeetingStatus
{
    IsNotAMeeting = 0,
    IsAMeeting = 1,
    MeetingReceived = 2,
    MeetingIsCancelled = 4,
}
