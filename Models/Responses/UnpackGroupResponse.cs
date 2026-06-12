#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Responses;

/// <summary>
/// Expanded recipient emails of a contact group. The unpack-group endpoint returns a
/// mixed array (bare email strings and/or contact objects) under one of several keys;
/// the SDK normalizes that into a flat email list at the JSON boundary.
/// </summary>
public record UnpackGroupResponse
{
    public bool Success { get; init; }
    public IReadOnlyList<string> Emails { get; init; } = System.Array.Empty<string>();
}
