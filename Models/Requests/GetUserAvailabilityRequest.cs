#nullable enable

using System;
using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

/// <summary>Query for free/busy availability of one or more users on a given day.</summary>
public record GetUserAvailabilityRequest
{
    public DateTime Date { get; init; }
    public IReadOnlyList<string> EmailAddresses { get; init; } = new List<string>();
    public string? UidToIgnore { get; init; }
}
