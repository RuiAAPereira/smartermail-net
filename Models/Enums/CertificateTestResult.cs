
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum CertificateTestResult
{
    FileNotFound = 0,
    InvalidCertificate = 1,
    Success = 2,
}
