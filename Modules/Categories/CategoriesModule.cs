#nullable enable

using SmarterMail.Net.Http;
using SmarterMail.Net.Models.Requests;
using SmarterMail.Net.Models.Responses;

namespace SmarterMail.Net.Modules.Categories;

/// <summary>Implements category operations via the SmarterMail HTTP API.</summary>
public sealed class CategoriesModule : ICategoriesModule
{
    private readonly ISmarterMailHttpClient _http;

    /// <summary>Initializes a new instance of <see cref="CategoriesModule"/>.</summary>
    public CategoriesModule(ISmarterMailHttpClient http) { _http = http; }

    /// <inheritdoc/>
    public Task<List<UserCategoryItem>> GetCategoriesAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<List<UserCategoryItem>>("/api/v1/user-categories", cancellationToken);

    /// <inheritdoc/>
    public Task<GetUsersCategoryListResponse> GetUserCategorySettingsAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetUsersCategoryListResponse>("/api/v1/categories/user-category-settings", cancellationToken);

    /// <inheritdoc/>
    public Task<UpdateUserCategorySettingsResponse> UpdateUserCategorySettingsAsync(UpdateUserCategorySettingsRequest request, CancellationToken cancellationToken = default)
        => _http.PostAsync<UpdateUserCategorySettingsResponse>("/api/v1/categories/user-category-settings", request, cancellationToken);

    /// <inheritdoc/>
    public Task<GetSharesCategoryListResponse> GetSharedCategorySettingsAsync(CancellationToken cancellationToken = default)
        => _http.GetAsync<GetSharesCategoryListResponse>("/api/v1/categories/shares-category-settings", cancellationToken);

    /// <inheritdoc/>
    public Task<GetCategoryFiltersResponse> GetCategoryFiltersAsync(string user, CancellationToken cancellationToken = default)
        => _http.GetAsync<GetCategoryFiltersResponse>(
            $"/api/v1/category-filters/{Uri.EscapeDataString(user)}", cancellationToken);
}
