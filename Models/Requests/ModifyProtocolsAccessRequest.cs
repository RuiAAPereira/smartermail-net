
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record ModifyProtocolsAccessRequest
{
    public JsonElement? Items { get; init; }
    public bool WebmailEnabled { get; init; }
    public bool SmtpEnabled { get; init; }
    public bool ImapEnabled { get; init; }
    public bool PopEnabled { get; init; }
    public bool XmppEnabled { get; init; }
    public bool EasEnabled { get; init; }
    public bool MapiEwsEnabled { get; init; }
}
