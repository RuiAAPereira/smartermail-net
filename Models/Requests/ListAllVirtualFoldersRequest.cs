
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ListAllVirtualFoldersRequest
{
    public SmarterMail.Net.Models.Enums.ShareType RestrictToType { get; init; }
}
