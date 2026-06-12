
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetDomainStatisticsResponse
{
    public string? DomainName { get; init; }
    public long MessagesReceived { get; init; }
    public long MessagesSent { get; init; }
    public long BytesReceived { get; init; }
    public long BytesSent { get; init; }
    public long BytesSize { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
