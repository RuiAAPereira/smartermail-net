
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ExportContactsRequest
{
    public JsonElement? Contacts { get; init; }
    public string? SourceOwner { get; init; }
    public string? SourceId { get; init; }
}
