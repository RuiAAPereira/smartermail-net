
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record UntrustSendersRequest
{
    public JsonElement? Uids { get; init; }
    public string? SourceFolder { get; init; }
    public string? SourceOwner { get; init; }
}
