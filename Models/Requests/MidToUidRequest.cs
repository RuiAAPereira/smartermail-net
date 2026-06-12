
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MidToUidRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
}
