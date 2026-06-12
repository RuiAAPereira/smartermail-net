
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetFolderRestrictionsRequest
{
    public JsonElement? FolderRestrictions { get; init; }
    public JsonElement? RestrictedWords { get; init; }
}
