#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

/// <summary>Per-user free/busy levels, one entry per hour of the requested day.</summary>
public record UserAvailability
{
    public string EmailAddress { get; init; } = string.Empty;
    public IReadOnlyList<AvailabilityLevel> BusyHours { get; init; } = new List<AvailabilityLevel>();
}
