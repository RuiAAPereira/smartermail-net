#nullable enable

using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Categories;

/// <summary>Operations for the authenticated user's mail and item categories.</summary>
public interface ICategoriesModule
{
    /// <summary>Retrieves the user's category list.</summary>
    Task<List<UserCategoryItem>> GetCategoriesAsync(CancellationToken cancellationToken = default);

    /// <summary>Retrieves the user's category settings.</summary>
    Task<GetUsersCategoryListResponse> GetUserCategorySettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>Updates the user's category settings.</summary>
    Task<UpdateUserCategorySettingsResponse> UpdateUserCategorySettingsAsync(UpdateUserCategorySettingsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retrieves category settings for shared folders.</summary>
    Task<GetSharesCategoryListResponse> GetSharedCategorySettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>Retrieves category filters for the specified user.</summary>
    Task<GetCategoryFiltersResponse> GetCategoryFiltersAsync(string user, CancellationToken cancellationToken = default);
}
