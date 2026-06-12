
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetMessageMetaDataRequest
{
    public JsonElement? Messages { get; init; }
    public bool NeedLocation { get; init; }
    public bool IsNew { get; init; }
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public long Uid { get; init; }
    public SmarterMail.Net.Models.Enums.MessageSortType SortType { get; init; }
    public bool SortAscending { get; init; }
    public SmarterMail.Net.Models.Enums.EmailMessageFlags Filter { get; init; }
}
