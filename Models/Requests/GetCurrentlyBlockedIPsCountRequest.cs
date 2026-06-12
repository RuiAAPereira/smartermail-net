
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetCurrentlyBlockedIPsCountRequest
{
    public string? Search { get; init; }
    public SmarterMail.Net.Models.Enums.IpBlockInfoSortType SortType { get; init; }
    public bool Ascending { get; init; }
    public int Startindex { get; init; }
}
