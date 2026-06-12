
#nullable enable

namespace SmarterMail.Net.Models.Responses;

/// <summary>One category entry as returned by <c>GET /api/v1/user-categories</c>.</summary>
public record UserCategoryItem
{
    /// <summary>Display name of the category.</summary>
    public string? Name { get; init; }

    /// <summary>Whether this is a master (shared / system-level) category.</summary>
    public bool Master { get; init; }
}
