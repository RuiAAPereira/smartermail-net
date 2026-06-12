using System.Net;
using System.Net.Http.Headers;
using System.Globalization;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using SmarterMail.Net.Authentication;
using SmarterMail.Net.Exceptions;

namespace SmarterMail.Net.Http;

/// <summary>
/// Sends authenticated HTTP requests to the SmarterMail API.
/// Injects Bearer tokens, serializes/deserializes JSON, handles errors and 401 retry.
/// </summary>
public sealed class SmarterMailHttpClient : ISmarterMailHttpClient
{
    private readonly HttpClient _httpClient;
    private readonly ISmarterMailAuthenticator _authenticator;
    private readonly ILogger<SmarterMailHttpClient> _logger;

    public SmarterMailHttpClient(
        HttpClient httpClient,
        ISmarterMailAuthenticator authenticator,
        ILogger<SmarterMailHttpClient> logger)
    {
        _httpClient = httpClient;
        _authenticator = authenticator;
        _logger = logger;
    }

    public Task<T> GetAsync<T>(string path, CancellationToken cancellationToken = default)
        => SendAsync<T>(() => new HttpRequestMessage(HttpMethod.Get, path), path, cancellationToken);

    public Task<T> PostAsync<T>(string path, object? body = null, CancellationToken cancellationToken = default)
        => SendAsync<T>(() => BuildRequest(HttpMethod.Post, path, body), path, cancellationToken);

    public Task<T> PutAsync<T>(string path, object? body = null, CancellationToken cancellationToken = default)
        => SendAsync<T>(() => BuildRequest(HttpMethod.Put, path, body), path, cancellationToken);

    public Task<T> DeleteAsync<T>(string path, CancellationToken cancellationToken = default)
        => SendAsync<T>(() => new HttpRequestMessage(HttpMethod.Delete, path), path, cancellationToken);

    // HttpMethod.Patch was added in .NET 5; use new HttpMethod("PATCH") for netstandard2.0 compat
    private static readonly HttpMethod PatchMethod = new HttpMethod("PATCH");

    public Task<T> PatchAsync<T>(string path, object? body = null, CancellationToken cancellationToken = default)
        => SendAsync<T>(() => BuildRequest(PatchMethod, path, body), path, cancellationToken);

    public async Task PostAsync(string path, object? body = null, CancellationToken cancellationToken = default)
    {
        using var response = await SendRawAsync(() => BuildRequest(HttpMethod.Post, path, body), path, cancellationToken).ConfigureAwait(false);
        await EnsureSuccessAsync(response, path, cancellationToken).ConfigureAwait(false);
    }

    public async Task<string> PostStringAsync(string path, object? body = null, CancellationToken cancellationToken = default)
    {
        using var response = await SendRawAsync(() => BuildRequest(HttpMethod.Post, path, body), path, cancellationToken).ConfigureAwait(false);
        await EnsureSuccessAsync(response, path, cancellationToken).ConfigureAwait(false);
        return await ReadStringAsync(response.Content, cancellationToken).ConfigureAwait(false);
    }

    public async Task<byte[]> PostBytesAsync(string path, object? body = null, CancellationToken cancellationToken = default)
    {
        using var response = await SendRawAsync(() => BuildRequest(HttpMethod.Post, path, body), path, cancellationToken).ConfigureAwait(false);
        await EnsureSuccessAsync(response, path, cancellationToken).ConfigureAwait(false);
        return await ReadBytesAsync(response.Content, cancellationToken).ConfigureAwait(false);
    }

    public async Task DeleteAsync(string path, CancellationToken cancellationToken = default)
    {
        using var response = await SendRawAsync(() => new HttpRequestMessage(HttpMethod.Delete, path), path, cancellationToken).ConfigureAwait(false);
        await EnsureSuccessAsync(response, path, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Stream> GetStreamAsync(string path, CancellationToken cancellationToken = default)
    {
        // Note: response is NOT disposed here — the caller owns the stream lifetime.
        var response = await SendRawAsync(() => new HttpRequestMessage(HttpMethod.Get, path), path, cancellationToken).ConfigureAwait(false);
        await EnsureSuccessAsync(response, path, cancellationToken).ConfigureAwait(false);
        return await ReadStreamAsync(response.Content, cancellationToken).ConfigureAwait(false);
    }

    public async Task<byte[]> GetBytesAsync(string urlOrPath, CancellationToken cancellationToken = default)
    {
        using var response = await SendRawAsync(() => new HttpRequestMessage(HttpMethod.Get, urlOrPath), urlOrPath, cancellationToken).ConfigureAwait(false);
        await EnsureSuccessAsync(response, urlOrPath, cancellationToken).ConfigureAwait(false);
        return await ReadBytesAsync(response.Content, cancellationToken).ConfigureAwait(false);
    }

    public async Task<T> PostMultipartAsync<T>(string path, Stream fileContent, string fileName, CancellationToken cancellationToken = default)
    {
        // Buffer the stream so the request factory can be called multiple times on 401 retry.
        byte[] buffer;
        if (fileContent is MemoryStream ms)
        {
            buffer = ms.ToArray();
        }
        else
        {
            using var buf = new MemoryStream();
            await fileContent.CopyToAsync(buf, 81920, cancellationToken).ConfigureAwait(false);
            buffer = buf.ToArray();
        }

        return await SendAsync<T>(() =>
        {
            var form = new MultipartFormDataContent();
            var streamContent = new ByteArrayContent(buffer);
            streamContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            form.Add(streamContent, "file", fileName);
            return new HttpRequestMessage(HttpMethod.Post, path) { Content = form };
        }, path, cancellationToken).ConfigureAwait(false);
    }

    public async Task<T> PostMultipartAsync<T>(string path, Stream fileContent, string fileName, string fileFieldName, IReadOnlyDictionary<string, string> fields, CancellationToken cancellationToken = default)
    {
        // Buffer the stream so the request factory can be called multiple times on 401 retry.
        byte[] buffer;
        if (fileContent is MemoryStream ms)
        {
            buffer = ms.ToArray();
        }
        else
        {
            using var buf = new MemoryStream();
            await fileContent.CopyToAsync(buf, 81920, cancellationToken).ConfigureAwait(false);
            buffer = buf.ToArray();
        }

        return await SendAsync<T>(() =>
        {
            var form = new MultipartFormDataContent();
            var streamContent = new ByteArrayContent(buffer);
            streamContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            form.Add(streamContent, fileFieldName, fileName);
            foreach (var field in fields)
                form.Add(new StringContent(field.Value), field.Key);
            return new HttpRequestMessage(HttpMethod.Post, path) { Content = form };
        }, path, cancellationToken).ConfigureAwait(false);
    }

    public Task<T> PostResumableAttachmentAsync<T>(string attachGuid, Stream fileContent, string fileName, CancellationToken cancellationToken = default)
    {
        var contextData = JsonSerializer.Serialize(new { guid = attachGuid });
        return PostResumableUploadAsync<T>("attachment", contextData, fileContent, fileName, string.Empty, cancellationToken);
    }

    public async Task<T> PostResumableUploadAsync<T>(string context, string contextData, Stream fileContent, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        // Read into memory first to know the total size (streams may not be seekable).
        byte[] bytes;
        if (fileContent is MemoryStream ms)
        {
            bytes = ms.ToArray();
        }
        else
        {
            using var buf = new MemoryStream();
            await fileContent.CopyToAsync(buf, 81920, cancellationToken).ConfigureAwait(false);
            bytes = buf.ToArray();
        }

        var totalSize = bytes.Length.ToString(CultureInfo.InvariantCulture);
        // resumable.js strips all non-alphanumeric chars (except _ and -) from the filename when building the identifier.
        var rawName = System.IO.Path.GetFileNameWithoutExtension(fileName) + System.IO.Path.GetExtension(fileName).TrimStart('.');
        var sanitizedName = System.Text.RegularExpressions.Regex.Replace(rawName, @"[^0-9a-zA-Z_\-]", string.Empty);
        var identifier = $"{bytes.Length}-{sanitizedName}";
        var mimeType = string.IsNullOrEmpty(contentType) ? GetMimeType(fileName) : contentType;
        var encodedContextData = Uri.EscapeDataString(contextData);

        // Step 1: GET preflight (resumable.js protocol — server validates the upload session before accepting the POST).
        var preflightPath = $"/api/upload?context={Uri.EscapeDataString(context)}&contextData={encodedContextData}" +
            $"&resumableChunkNumber=1&resumableChunkSize=2097152" +
            $"&resumableCurrentChunkSize={totalSize}&resumableTotalSize={totalSize}" +
            $"&resumableType={Uri.EscapeDataString(mimeType)}&resumableIdentifier={Uri.EscapeDataString(identifier)}" +
            $"&resumableFilename={Uri.EscapeDataString(fileName)}&resumableRelativePath={Uri.EscapeDataString(fileName)}" +
            $"&resumableTotalChunks=1";

        using var preflightResponse = await SendRawAsync(
            () => new HttpRequestMessage(HttpMethod.Get, preflightPath), preflightPath, cancellationToken)
            .ConfigureAwait(false);
        // 200 = chunk not found (proceed), 204 = already uploaded (skip). Both are acceptable.

        // Step 2: POST the file.
        const string path = "/api/upload";
        return await SendAsync<T>(() =>
        {
            var form = new MultipartFormDataContent
            {
                { new StringContent("1"), "resumableChunkNumber" },
                { new StringContent("2097152"), "resumableChunkSize" },
                { new StringContent(totalSize), "resumableCurrentChunkSize" },
                { new StringContent(totalSize), "resumableTotalSize" },
                { new StringContent(mimeType), "resumableType" },
                { new StringContent(identifier), "resumableIdentifier" },
                { new StringContent(fileName), "resumableFilename" },
                { new StringContent(fileName), "resumableRelativePath" },
                { new StringContent("1"), "resumableTotalChunks" },
                { new StringContent(context), "context" },
                { new StringContent(contextData), "contextData" }
            };

            var fileContent2 = new ByteArrayContent(bytes);
            fileContent2.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            form.Add(fileContent2, "file", "blob");

            return new HttpRequestMessage(HttpMethod.Post, path) { Content = form };
        }, path, cancellationToken).ConfigureAwait(false);
    }

    private async Task<T> SendAsync<T>(Func<HttpRequestMessage> requestFactory, string path, CancellationToken cancellationToken)
    {
        using var response = await SendRawAsync(requestFactory, path, cancellationToken).ConfigureAwait(false);
        await EnsureSuccessAsync(response, path, cancellationToken).ConfigureAwait(false);
        var json = await ReadStringAsync(response.Content, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<T>(json, SmarterMailJsonOptions.Default)!;
    }

    private async Task<HttpResponseMessage> SendRawAsync(Func<HttpRequestMessage> requestFactory, string path, CancellationToken cancellationToken)
    {
        var token = await _authenticator.GetAccessTokenAsync(cancellationToken).ConfigureAwait(false);
        var request = requestFactory();
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        _logger.LogDebug("{Method} {Path}", request.Method, path);

        var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
        _logger.LogDebug("{Method} {Path} → {StatusCode}", request.Method, path, (int)response.StatusCode);

        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            await _authenticator.ForceRefreshAsync(cancellationToken).ConfigureAwait(false);
            var newToken = await _authenticator.GetAccessTokenAsync(cancellationToken).ConfigureAwait(false);

            var retryRequest = requestFactory();
            retryRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", newToken);
            response.Dispose();
            response = await _httpClient.SendAsync(retryRequest, cancellationToken).ConfigureAwait(false);
            _logger.LogDebug("{Method} {Path} retry → {StatusCode}", retryRequest.Method, path, (int)response.StatusCode);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
                throw new SmarterMailAuthenticationException("Authentication failed after token refresh.");
        }

        return response;
    }

    private async Task EnsureSuccessAsync(HttpResponseMessage response, string path, CancellationToken cancellationToken)
    {
        if (response.IsSuccessStatusCode) return;

        var body = await ReadStringAsync(response.Content, cancellationToken).ConfigureAwait(false);
        var statusCode = (int)response.StatusCode;

        // 5xx = server fault → Error; 4xx = client/expected → Warning (callers handle these via catch)
        if (statusCode >= 500)
            _logger.LogError("API error {StatusCode} on {Path}: {Body}", statusCode, path, body);
        else
            _logger.LogWarning("API error {StatusCode} on {Path}: {Body}", statusCode, path, body);

        throw new SmarterMailApiException(statusCode, body);
    }

    private static Task<string> ReadStringAsync(HttpContent content, CancellationToken cancellationToken)
    {
#if NET10_0_OR_GREATER
        return content.ReadAsStringAsync(cancellationToken);
#else
        _ = cancellationToken;
        return content.ReadAsStringAsync();
#endif
    }

    private static Task<byte[]> ReadBytesAsync(HttpContent content, CancellationToken cancellationToken)
    {
#if NET10_0_OR_GREATER
        return content.ReadAsByteArrayAsync(cancellationToken);
#else
        _ = cancellationToken;
        return content.ReadAsByteArrayAsync();
#endif
    }

    private static Task<Stream> ReadStreamAsync(HttpContent content, CancellationToken cancellationToken)
    {
#if NET10_0_OR_GREATER
        return content.ReadAsStreamAsync(cancellationToken);
#else
        _ = cancellationToken;
        return content.ReadAsStreamAsync();
#endif
    }

    private static string GetMimeType(string fileName)
    {
        var ext = System.IO.Path.GetExtension(fileName)?.ToLowerInvariant() ?? string.Empty;
        return ext switch
        {
            ".pdf" => "application/pdf",
            ".png" => "image/png",
            ".jpg" => "image/jpeg",
            ".jpeg" => "image/jpeg",
            ".gif" => "image/gif",
            ".webp" => "image/webp",
            ".bmp" => "image/bmp",
            ".doc" => "application/msword",
            ".docx" => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
            ".xls" => "application/vnd.ms-excel",
            ".xlsx" => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            ".ppt" => "application/vnd.ms-powerpoint",
            ".pptx" => "application/vnd.openxmlformats-officedocument.presentationml.presentation",
            ".txt" => "text/plain",
            ".csv" => "text/csv",
            ".zip" => "application/zip",
            ".mp3" => "audio/mpeg",
            ".mp4" => "video/mp4",
            _ => "application/octet-stream"
        };
    }

    private static HttpRequestMessage BuildRequest(HttpMethod method, string path, object? body)
    {
        var request = new HttpRequestMessage(method, path);
        if (body != null)
        {
            var json = JsonSerializer.Serialize(body, SmarterMailJsonOptions.Default);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
        }
        return request;
    }
}
