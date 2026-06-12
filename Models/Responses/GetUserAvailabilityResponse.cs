#nullable enable

using System.Collections.Generic;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

/// <summary>SDK-side wrapper over the bare array the user-availability endpoint returns.</summary>
public record GetUserAvailabilityResponse
{
    public IReadOnlyList<UserAvailability> Users { get; init; } = new List<UserAvailability>();
}
