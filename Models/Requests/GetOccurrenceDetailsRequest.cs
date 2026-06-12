#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

/// <summary>Body for the occurrence-details endpoint: identifies one occurrence of a recurring series.</summary>
public record GetOccurrenceDetailsRequest
{
    public JsonElement? OccurrenceId { get; init; }
}
