
#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

public record BlockSendersRequest
{
    public Dictionary<string, List<long>>? BlockedSenders { get; init; }
    public string? SourceFolder { get; init; }
    public string? SourceOwner { get; init; }
    public bool IsSender { get; init; }
}
