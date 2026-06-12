#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

public record MessagesFlagPatchRequest
{
    public string? OwnerEmailAddress { get; init; }
    public string? Folder { get; init; }
    public List<long>? Uid { get; init; }
    public MessageFlagAction? FlagAction { get; init; }
}

public record MessageFlagAction
{
    /// <summary>
    /// The flag action type. Known values: "SetBasic", "SetFollowup", "Complete", "Clear".
    /// </summary>
    public string? Type { get; init; }
}
