#nullable enable

namespace SmarterMail.Net.Models.Shared;

/// <summary>A category assigned to a calendar event.</summary>
public record EventCategory
{
    public string Name { get; init; } = string.Empty;
    public bool Master { get; init; }
    public bool Selected { get; init; }
}
