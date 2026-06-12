
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record RenameUserCalendarRequest
{
    public long Id { get; init; }
    public string? Name { get; init; }
    public string? Owner { get; init; }
}
