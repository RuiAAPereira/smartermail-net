
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetFolderRequest
{
    public string? Email { get; init; }
}
