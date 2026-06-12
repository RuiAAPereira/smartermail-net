
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record DeleteAddressBookRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
}
