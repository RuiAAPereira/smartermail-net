
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteNotesRequest
{
    public string? SourceOwner { get; init; }
    public string? SourceId { get; init; }
}
