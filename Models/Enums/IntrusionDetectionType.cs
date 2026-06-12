
namespace SmarterMail.Net.Models.Enums;

public enum IntrusionDetectionType
{
    DenialOfService = 0,
    EmailHarvesting = 1,
    InternalSpammer = 2,
    BruteForceByIp = 3,
    BouncesIndicateSpammer = 4,
    BruteForceByEmail = 5,
    PasswordRetrievalBruteForce = 6,
    Unknown = 7,
}
