namespace SmarterMail.Net.Exceptions;

/// <summary>Base exception for all SmarterMail SDK errors.</summary>
public class SmarterMailException : Exception
{
    public SmarterMailException(string message) : base(message) { }
    public SmarterMailException(string message, Exception innerException) : base(message, innerException) { }
}
