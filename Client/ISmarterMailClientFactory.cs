namespace SmarterMail.Net.Client;

/// <summary>
/// Creates per-user <see cref="SmarterMailClient"/> instances backed by a shared HTTP connection pool.
/// </summary>
public interface ISmarterMailClientFactory
{
    /// <summary>
    /// Creates a <see cref="SmarterMailClient"/> authenticated as the given user.
    /// The caller is responsible for disposing the returned instance.
    /// </summary>
    SmarterMailClient Create(string username, string password);
}
