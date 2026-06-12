
#nullable enable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Requests;

public record GetMessagesRequest
{
    public string? Query { get; init; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IncludeSubFolders { get; init; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public SmarterMail.Net.Models.Enums.EmailSearchQueryField FieldsToSearch { get; init; }
    public Dictionary<string, bool>? SearchFlags { get; init; }
    public Dictionary<string, string>? SearchFieldValueMap { get; init; }
    public DateTime? MessagesSince { get; init; }
    public DateTime? MessagesBefore { get; init; }
    public long? MaxSizeInBytes { get; init; }
    public long? MinSizeInBytes { get; init; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool UseContentFieldOnly { get; init; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool ExperimentalSpeedup { get; init; }
    [JsonPropertyName("oR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool OR { get; init; }
    public JsonElement? CategoryFilter { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public int Skip { get; init; }
    public int Take { get; init; }
    public List<long>? SelectedIds { get; init; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public SmarterMail.Net.Models.Enums.MessageSortType SortType { get; init; }
    public bool SortAscending { get; init; }
}
