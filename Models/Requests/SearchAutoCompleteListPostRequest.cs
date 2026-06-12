#nullable enable

namespace SmarterMail.Net.Models.Requests;

/// <summary>Search criteria for the auto-complete address list (GAL, contacts, and history).</summary>
public record SearchAutoCompleteListPostRequest
{
    /// <summary>The text to match against display names and email addresses.</summary>
    public string? Search { get; init; }

    /// <summary>Maximum number of entries to return.</summary>
    public int RequestLimit { get; init; } = 200;

    /// <summary>When true, expands mailing-list groups into their member addresses.</summary>
    public bool UnpackGroups { get; init; }
}
