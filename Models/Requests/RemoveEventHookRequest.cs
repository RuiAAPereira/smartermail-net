#nullable enable

using System;
using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

/// <summary>Request body for POST /api/v1/settings/event-hook-delete. `input` is the list of hook guids.</summary>
public record RemoveEventHookRequest
{
    public IReadOnlyList<string> Input { get; init; } = Array.Empty<string>();
}
