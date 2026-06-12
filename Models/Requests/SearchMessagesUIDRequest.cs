
#nullable enable

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Requests;

public record SearchMessagesUIDRequest
{
    public string? Query { get; init; }
    public bool IncludeSubFolders { get; init; }
    public SmarterMail.Net.Models.Enums.EmailSearchQueryField FieldsToSearch { get; init; }
    public Dictionary<string, bool>? SearchFlags { get; init; }
    public Dictionary<string, string>? SearchFieldValueMap { get; init; }
    public DateTime? MessagesSince { get; init; }
    public DateTime? MessagesBefore { get; init; }
    public long? MaxSizeInBytes { get; init; }
    public long? MinSizeInBytes { get; init; }
    public bool UseContentFieldOnly { get; init; }
    public bool ExperimentalSpeedup { get; init; }
    [JsonPropertyName("oR")]
    public bool OR { get; init; }
    public JsonElement? CategoryFilter { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public int Skip { get; init; }
    public int Take { get; init; }
    public List<long>? SelectedIds { get; init; }
    public SmarterMail.Net.Models.Enums.MessageSortType SortType { get; init; }
}
