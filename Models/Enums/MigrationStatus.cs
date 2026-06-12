
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum MigrationStatus
{
    QUEUED = 0,
    RUNNING = 1,
    COMPLETED = 2,
}
