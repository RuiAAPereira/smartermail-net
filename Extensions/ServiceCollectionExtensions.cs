using Microsoft.Extensions.DependencyInjection;
using SmarterMail.Net.Client;
using SmarterMail.Net.Configuration;

namespace SmarterMail.Net.Extensions;

/// <summary>Extension methods for registering the SmarterMail SDK with DI.</summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers the SmarterMail SDK services. Validates options at registration time.
    /// </summary>
    public static IServiceCollection AddDotNetSmarterMailClient(
        this IServiceCollection services,
        Action<SmarterMailClientOptions> configure)
    {
        var options = new SmarterMailClientOptions();
        configure(options);

        if (string.IsNullOrWhiteSpace(options.BaseUrl))
            throw new ArgumentException("BaseUrl is required.", nameof(configure));

        services.AddSingleton(options);

        services.AddHttpClient("smartermail-auth", client =>
        {
            client.BaseAddress = new Uri(options.BaseUrl.TrimEnd('/'));
        });

        services.AddHttpClient("smartermail-api", client =>
        {
            client.BaseAddress = new Uri(options.BaseUrl.TrimEnd('/'));
        });

        services.AddSingleton<ISmarterMailClientFactory, SmarterMailClientFactory>();

        return services;
    }
}
