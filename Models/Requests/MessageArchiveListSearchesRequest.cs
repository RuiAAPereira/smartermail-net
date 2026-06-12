
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MessageArchiveListSearchesRequest
{
    public bool SortDescending { get; init; }
    public long Count { get; init; }
}
