
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SharedResourceRenameRequest
{
    public long FolderId { get; init; }
}
