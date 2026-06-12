namespace SmarterMail.Net.Http;

/// <summary>
/// Abstraction for all authenticated HTTP communication with the SmarterMail API.
/// </summary>
public interface ISmarterMailHttpClient
{
    /// <summary>Sends a GET request and deserializes the response as <typeparamref name="T"/>.</summary>
    Task<T> GetAsync<T>(string path, CancellationToken cancellationToken = default);

    /// <summary>Sends a POST request with an optional body and deserializes the response as <typeparamref name="T"/>.</summary>
    Task<T> PostAsync<T>(string path, object? body = null, CancellationToken cancellationToken = default);

    /// <summary>Sends a PUT request with an optional body and deserializes the response as <typeparamref name="T"/>.</summary>
    Task<T> PutAsync<T>(string path, object? body = null, CancellationToken cancellationToken = default);

    /// <summary>Sends a DELETE request and deserializes the response as <typeparamref name="T"/>.</summary>
    Task<T> DeleteAsync<T>(string path, CancellationToken cancellationToken = default);

    /// <summary>Sends a PATCH request with an optional body and deserializes the response as <typeparamref name="T"/>.</summary>
    Task<T> PatchAsync<T>(string path, object? body = null, CancellationToken cancellationToken = default);

    /// <summary>Sends a POST request with an optional body and discards the response body.</summary>
    Task PostAsync(string path, object? body = null, CancellationToken cancellationToken = default);

    /// <summary>Sends a POST request with an optional body and returns the raw response body as a string.</summary>
    Task<string> PostStringAsync(string path, object? body = null, CancellationToken cancellationToken = default);

    /// <summary>Sends a POST request with an optional body and returns the raw response body as a byte array.</summary>
    Task<byte[]> PostBytesAsync(string path, object? body = null, CancellationToken cancellationToken = default);

    /// <summary>Sends a DELETE request and discards the response body.</summary>
    Task DeleteAsync(string path, CancellationToken cancellationToken = default);

    /// <summary>Sends a GET request and returns the raw response stream. Caller owns the stream lifetime.</summary>
    Task<Stream> GetStreamAsync(string path, CancellationToken cancellationToken = default);

    /// <summary>Sends a GET request and returns the raw response body as a byte array. Accepts absolute URLs (e.g. pre-signed attachment links).</summary>
    Task<byte[]> GetBytesAsync(string urlOrPath, CancellationToken cancellationToken = default);

    /// <summary>Sends a POST request with a multipart/form-data body containing a single file and deserializes the response as <typeparamref name="T"/>.</summary>
    Task<T> PostMultipartAsync<T>(string path, Stream fileContent, string fileName, CancellationToken cancellationToken = default);

    /// <summary>Posts multipart form data: one file part plus arbitrary string fields.</summary>
    Task<T> PostMultipartAsync<T>(string path, Stream fileContent, string fileName, string fileFieldName, IReadOnlyDictionary<string, string> fields, CancellationToken cancellationToken = default);

    /// <summary>
    /// Uploads a file to /api/upload using SmarterMail's resumable-upload protocol so the server
    /// registers it under the given attachment GUID. Only single-chunk uploads are supported.
    /// </summary>
    Task<T> PostResumableAttachmentAsync<T>(string attachGuid, Stream fileContent, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Uploads a file to /api/upload using SmarterMail's resumable-upload protocol with an
    /// arbitrary <paramref name="context"/> and <paramref name="contextData"/> (JSON string).
    /// Only single-chunk uploads are supported.
    /// When <paramref name="contentType"/> is null or empty the MIME type is derived from the file extension of <paramref name="fileName"/>.
    /// </summary>
    Task<T> PostResumableUploadAsync<T>(string context, string contextData, Stream fileContent, string fileName, string contentType, CancellationToken cancellationToken = default);
}
