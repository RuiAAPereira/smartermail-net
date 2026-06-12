
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record TrustSendersRequest
{
    public JsonElement? Uids { get; init; }
    public string? SourceFolder { get; init; }
    public string? SourceOwner { get; init; }
}
