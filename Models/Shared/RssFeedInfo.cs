// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "rssFeed" sub-object returned by the RSS data endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System;

namespace SmarterMail.Net.Models.Shared;

public record RssFeedInfo
{
    public DateTime? LastUpdated { get; init; }
    public string? ChannelTitle { get; init; }
    public string? ChannelDescription { get; init; }
}
