
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record RenameDomainRequest
{
    public string? OldDomainName { get; init; }
}
