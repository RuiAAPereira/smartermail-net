namespace SmarterMail.Net.Authentication;

/// <summary>Manages authentication tokens for the SmarterMail API.</summary>
public interface ISmarterMailAuthenticator
{
    /// <summary>
    /// Returns a valid access token, performing login or proactive refresh as needed.
    /// Thread-safe.
    /// </summary>
    Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Forces an immediate token refresh. Tries the refresh-token endpoint first;
    /// falls back to full re-authentication if the refresh token is expired or invalid.
    /// Called by the HTTP client on receiving a 401 response.
    /// </summary>
    Task ForceRefreshAsync(CancellationToken cancellationToken = default);
}
