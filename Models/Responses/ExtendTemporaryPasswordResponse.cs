
#nullable enable

using System;
using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ExtendTemporaryPasswordResponse
{
    public string? TempPassword { get; init; }
    public DateTime? TempPasswordExpUtc { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
