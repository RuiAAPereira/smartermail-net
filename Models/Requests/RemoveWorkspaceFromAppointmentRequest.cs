
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record RemoveWorkspaceFromAppointmentRequest
{
    public JsonElement? Ids { get; init; }
}
