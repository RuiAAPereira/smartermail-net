namespace SmarterMail.Net.Exceptions;

/// <summary>Thrown when the SmarterMail API returns a non-success, non-401 response.</summary>
public class SmarterMailApiException : SmarterMailException
{
    /// <summary>The HTTP status code returned by the API.</summary>
    public int StatusCode { get; }

    public SmarterMailApiException(int statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }
}
