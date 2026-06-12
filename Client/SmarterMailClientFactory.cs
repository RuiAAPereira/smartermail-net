using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmarterMail.Net.Authentication;
using SmarterMail.Net.Http;
using SmarterMail.Net.Modules.Calendar;
using SmarterMail.Net.Modules.Categories;
using SmarterMail.Net.Modules.Contacts;
using SmarterMail.Net.Modules.FileStorage;
using SmarterMail.Net.Modules.Folders;
using SmarterMail.Net.Modules.Mail;
using SmarterMail.Net.Modules.Notes;
using SmarterMail.Net.Modules.Notifications;
using SmarterMail.Net.Modules.Tasks;
using SmarterMail.Net.Modules.UserSettings;

namespace SmarterMail.Net.Client;

internal sealed class SmarterMailClientFactory : ISmarterMailClientFactory
{
    private readonly IServiceProvider _root;
    private readonly IHttpClientFactory _httpClientFactory;

    public SmarterMailClientFactory(IServiceProvider root, IHttpClientFactory httpClientFactory)
    {
        _root = root;
        _httpClientFactory = httpClientFactory;
    }


    public SmarterMailClient Create(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username is required.", nameof(username));
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password is required.", nameof(password));

        var authHttp = _httpClientFactory.CreateClient("smartermail-auth");
        var authLogger = _root.GetRequiredService<ILogger<SmarterMailAuthenticator>>();
        var authenticator = new SmarterMailAuthenticator(authHttp, username, password, authLogger);

        var apiHttp = _httpClientFactory.CreateClient("smartermail-api");
        var httpClientLogger = _root.GetRequiredService<ILogger<SmarterMailHttpClient>>();
        ISmarterMailHttpClient http = new SmarterMailHttpClient(apiHttp, authenticator, httpClientLogger);

        return new SmarterMailClient(
            authenticator,
            new MailModule(http),
            new CalendarModule(http),
            new ContactsModule(http),
            new NotesModule(http),
            new TasksModule(http),
            new NotificationsModule(http),
            new CategoriesModule(http),
            new UserSettingsModule(http),
            new FoldersModule(http),
            new FileStorageModule(http));
    }
}
