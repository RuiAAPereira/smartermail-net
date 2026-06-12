
namespace SmarterMail.Net.Models.Enums;

public enum SmtpTestResults
{
    None = 0,
    Success = 1,
    FailedToResolveHostname = 2,
    FailedToConnect = 3,
    ReceivedBadResponse = 4,
    SslNegotiationFailed = 5,
    TlsNotSupported = 6,
    TlsNegotiationFailed = 7,
    AuthenticationFailed = 8,
    AuthenticatedUserEmailMissMatch = 9,
    UnknownError = 100,
    Unknown = 200,
}
