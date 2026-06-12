using System.Text;
using System.Text.Json;
using System.Threading;
using Microsoft.Extensions.Logging;
using SmarterMail.Net.Authentication.Internal;
using SmarterMail.Net.Exceptions;
using SmarterMail.Net.Http;

namespace SmarterMail.Net.Authentication;

/// <summary>
/// Authenticates against the SmarterMail API, caches tokens,
/// and refreshes them proactively or on demand.
/// </summary>
public sealed class SmarterMailAuthenticator : ISmarterMailAuthenticator, IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly string _username;
    private readonly string _password;
    private readonly ILogger<SmarterMailAuthenticator> _logger;
    private readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);

    private volatile string? _accessToken;
    private volatile string? _refreshToken;
    private long _accessTokenExpiryTicks = DateTime.MinValue.Ticks;
    private long _refreshTokenExpiryTicks = DateTime.MinValue.Ticks;

    // Renew 30 seconds before actual expiry to avoid race conditions
    private static readonly TimeSpan ExpiryBuffer = TimeSpan.FromSeconds(30);

    /// <summary>
    /// Initializes a new instance of <see cref="SmarterMailAuthenticator"/>.
    /// </summary>
    public SmarterMailAuthenticator(
        HttpClient httpClient,
        string username,
        string password,
        ILogger<SmarterMailAuthenticator> logger)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username is required.", nameof(username));
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password is required.", nameof(password));

        _httpClient = httpClient;
        _username = username;
        _password = password;
        _logger = logger;
    }

    /// <inheritdoc/>
    public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        if (_accessToken != null && DateTime.UtcNow < new DateTime(Interlocked.Read(ref _accessTokenExpiryTicks), DateTimeKind.Utc) - ExpiryBuffer)
            return _accessToken;

        await _lock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            // Double-check after acquiring lock
            if (_accessToken != null && DateTime.UtcNow < new DateTime(Interlocked.Read(ref _accessTokenExpiryTicks), DateTimeKind.Utc) - ExpiryBuffer)
                return _accessToken;

            if (_refreshToken != null && DateTime.UtcNow < new DateTime(Interlocked.Read(ref _refreshTokenExpiryTicks), DateTimeKind.Utc) - ExpiryBuffer)
                await RefreshTokenAsync(cancellationToken).ConfigureAwait(false);
            else
                await LoginAsync(cancellationToken).ConfigureAwait(false);

            return _accessToken!;
        }
        finally
        {
            _lock.Release();
        }
    }

    /// <inheritdoc/>
    public async Task ForceRefreshAsync(CancellationToken cancellationToken = default)
    {
        await _lock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (_refreshToken != null)
            {
                try
                {
                    await RefreshTokenAsync(cancellationToken).ConfigureAwait(false);
                    return;
                }
                catch (SmarterMailAuthenticationException)
                {
                    _logger.LogWarning("Refresh token failed, falling back to full login.");
                }
            }

            await LoginAsync(cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            _lock.Release();
        }
    }

    private async Task LoginAsync(CancellationToken cancellationToken)
    {
        _logger.LogDebug("Authenticating with SmarterMail as {Username}.", _username);

        var body = JsonSerializer.Serialize(
            new { username = _username, password = _password },
            SmarterMailJsonOptions.Default);

        var response = await _httpClient
            .PostAsync("/api/v1/auth/authenticate-user",
                new StringContent(body, Encoding.UTF8, "application/json"),
                cancellationToken)
            .ConfigureAwait(false);

        await ApplyTokenResponseAsync(response, "Login").ConfigureAwait(false);
    }

    private async Task RefreshTokenAsync(CancellationToken cancellationToken)
    {
        _logger.LogDebug("Refreshing access token.");

        var body = JsonSerializer.Serialize(
            new { token = _refreshToken },
            SmarterMailJsonOptions.Default);

        var response = await _httpClient
            .PostAsync("/api/v1/auth/refresh-token",
                new StringContent(body, Encoding.UTF8, "application/json"),
                cancellationToken)
            .ConfigureAwait(false);

        await ApplyTokenResponseAsync(response, "Refresh").ConfigureAwait(false);
    }

    private async Task ApplyTokenResponseAsync(HttpResponseMessage response, string operation)
    {
        if (!response.IsSuccessStatusCode)
        {
            throw new SmarterMailAuthenticationException(
                $"{operation} failed with status {(int)response.StatusCode}.");
        }

        var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        var result = JsonSerializer.Deserialize<TokenResponse>(json, SmarterMailJsonOptions.Default);

        if (result == null || !result.Success || string.IsNullOrEmpty(result.AccessToken))
            throw new SmarterMailAuthenticationException($"{operation} returned an invalid token response.");

        _accessToken = result.AccessToken;
        _refreshToken = result.RefreshToken;
        Interlocked.Exchange(ref _accessTokenExpiryTicks, (result.AccessTokenExpiration?.ToUniversalTime() ?? DateTime.UtcNow.AddHours(1)).Ticks);
        Interlocked.Exchange(ref _refreshTokenExpiryTicks, (result.RefreshTokenExpiration?.ToUniversalTime() ?? DateTime.UtcNow.AddDays(7)).Ticks);
    }

    /// <inheritdoc/>
    public void Dispose() => _lock.Dispose();
}
