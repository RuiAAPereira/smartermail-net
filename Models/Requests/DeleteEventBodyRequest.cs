#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

/// <summary>Optional body for the single-event delete endpoint. When <see cref="InstanceStart"/>
/// is set, only that occurrence of a recurring series is deleted; otherwise the whole series.</summary>
public record DeleteEventBodyRequest
{
    public JsonElement? InstanceStart { get; init; }
}
