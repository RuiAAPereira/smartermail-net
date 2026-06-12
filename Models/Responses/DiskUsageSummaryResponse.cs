// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record DiskUsageSummaryResponse
{
    public DiskUsageInfo? DiskUsage { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }

    // Convenience pass-throughs so callers don't need to null-check DiskUsage.
    public long Allowed => DiskUsage?.Allowed ?? 0;
    public long Used => DiskUsage?.Used ?? 0;
}