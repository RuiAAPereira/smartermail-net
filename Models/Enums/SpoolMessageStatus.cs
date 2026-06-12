
namespace SmarterMail.Net.Models.Enums;

public enum SpoolMessageStatus
{
    Writing = 0,
    Delay = 1,
    SpoolExecutable = 2,
    SpamCheck = 3,
    LocalDelivery = 4,
    RemoteDelivery = 5,
    RemoteDeliveryProcessing = 6,
    Quarantined = 7,
}
