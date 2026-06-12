namespace SmarterMail.Net.Exceptions;

/// <summary>Thrown when authentication or token refresh fails.</summary>
public class SmarterMailAuthenticationException : SmarterMailException
{
    public SmarterMailAuthenticationException(string message) : base(message) { }
    public SmarterMailAuthenticationException(string message, Exception innerException) : base(message, innerException) { }
}
