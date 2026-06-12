
#nullable enable

using System.Collections.Generic;

namespace SmarterMail.Net.Models.Requests;

public record UndoMessageRequest
{
    /// <summary>The unique identifiers of the messages to undo.</summary>
    public List<long>? Uids { get; init; }

    /// <summary>If true, the message is a scheduled send; if false, it is a delayed send.</summary>
    public bool IsScheduled { get; init; }

    /// <summary>If true, keep the message in its current folder instead of moving it back to Drafts.</summary>
    public bool KeepInFolder { get; init; }
}
