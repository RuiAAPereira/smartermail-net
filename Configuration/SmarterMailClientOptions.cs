namespace SmarterMail.Net.Configuration;

/// <summary>
/// Configuration options for the SmarterMail client.
/// </summary>
public class SmarterMailClientOptions
{
    /// <summary>The base URL of the SmarterMail server (e.g., https://mail.example.com).</summary>
    public string BaseUrl { get; set; } = string.Empty;
}
