
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record MessageArchiveListPanelSearchRequest
{
    public bool SortDescending { get; init; }
    public long Count { get; init; }
}
