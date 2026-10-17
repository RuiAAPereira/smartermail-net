using System.Threading;
using SmarterMail.Net.Authentication;
using SmarterMail.Net.Modules.Calendar;
using SmarterMail.Net.Modules.Categories;
using SmarterMail.Net.Modules.Contacts;
using SmarterMail.Net.Modules.Events;
using SmarterMail.Net.Modules.FileStorage;
using SmarterMail.Net.Modules.Folders;
using SmarterMail.Net.Modules.Mail;
using SmarterMail.Net.Modules.Notes;
using SmarterMail.Net.Modules.Notifications;
using SmarterMail.Net.Modules.Tasks;
using SmarterMail.Net.Modules.UserSettings;

namespace SmarterMail.Net.Client;

/// <summary>
/// Entry point for the SmarterMail SDK. Provides access to all API modules.
/// </summary>
public sealed class SmarterMailClient : IAsyncDisposable
{
    private readonly SmarterMailAuthenticator _authenticator;
    private int _disposed; // 0 = not disposed, 1 = disposed
    /// <summary>Operations for the authenticated user's email mailbox.</summary>
    public IMailModule Mail { get; }

    /// <summary>Operations for the authenticated user's calendar.</summary>
    public ICalendarModule Calendar { get; }

    /// <summary>Operations for the authenticated user's contacts.</summary>
    public IContactsModule Contacts { get; }

    /// <summary>Operations for the authenticated user's notes.</summary>
    public INotesModule Notes { get; }

    /// <summary>Operations for the authenticated user's tasks.</summary>
    public ITasksModule Tasks { get; }

    /// <summary>Operations for the authenticated user's notifications and alerts.</summary>
    public INotificationsModule Notifications { get; }

    /// <summary>Operations for the authenticated user's mail and item categories.</summary>
    public ICategoriesModule Categories { get; }

    /// <summary>Operations for the authenticated user's account settings, signatures, and auto-reply.</summary>
    public IUserSettingsModule UserSettings { get; }

    /// <summary>Operations for the authenticated user's email folders and virtual folders.</summary>
    public IFoldersModule Folders { get; }

    /// <summary>Operations for the authenticated user's file storage.</summary>
    public IFileStorageModule FileStorage { get; }

    /// <summary>Operations for the authenticated user's event hooks (events, actions, webhooks).</summary>
    public IEventHooksModule EventHooks { get; }

    /// <summary>Initializes a new instance of <see cref="SmarterMailClient"/>.</summary>
    public SmarterMailClient(
        SmarterMailAuthenticator authenticator,
        IMailModule mail,
        ICalendarModule calendar,
        IContactsModule contacts,
        INotesModule notes,
        ITasksModule tasks,
        INotificationsModule notifications,
        ICategoriesModule categories,
        IUserSettingsModule userSettings,
        IFoldersModule folders,
        IFileStorageModule fileStorage,
        IEventHooksModule eventHooks)
    {
        _authenticator = authenticator;
        Mail = mail;
        Calendar = calendar;
        Contacts = contacts;
        Notes = notes;
        Tasks = tasks;
        Notifications = notifications;
        Categories = categories;
        UserSettings = userSettings;
        Folders = folders;
        FileStorage = fileStorage;
        EventHooks = eventHooks;
    }

    /// <inheritdoc/>
    public ValueTask DisposeAsync()
    {
        if (Interlocked.CompareExchange(ref _disposed, 1, 0) != 0) return new ValueTask();
        _authenticator.Dispose();
        return new ValueTask();
    }
}
