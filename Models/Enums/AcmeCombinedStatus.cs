
namespace SmarterMail.Net.Models.Enums;

public enum AcmeCombinedStatus
{
    Unset = 0,
    Disabled = 1,
    ValidationPending = 2,
    ValidationCompletedPendingGeneration = 3,
    Active = 4,
    ActiveWithBindingError = 5,
    CannotBeAccessedThroughHttp = 6,
    Deactivated = 7,
    Expired = 8,
    Revoked = 9,
    ValidationFailed = 10,
    PendingWithErrors = 11,
    ValidationPendingWithErrors = 12,
}
