
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetUsersOutOfPasswordComplianceMinusActiveDirectoryListingRequest
{
    public int Skip { get; init; }
    public int Take { get; init; }
    public string? Search { get; init; }
    public string? SortField { get; init; }
}
