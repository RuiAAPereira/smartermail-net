// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "diskUsage" sub-object returned by the disk usage summary endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Shared;

public record DiskUsageInfo
{
    public long Allowed { get; init; }
    public long Used { get; init; }
    public long MailboxUsed { get; init; }
    public long AppointmentsUsed { get; init; }
    public long ContactsUsed { get; init; }
    public long NotesUsed { get; init; }
    public long TasksUsed { get; init; }
    public long FileStorageUsed { get; init; }
    public long MeetingWorkspaceUsed { get; init; }
    public long ChatFilesUsed { get; init; }
    public IReadOnlyList<DiskUsageFolderUsage>? Folders { get; init; }
    public string? Name { get; init; }
}
