
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetPasswordRequirementsResponse
{
    public bool ReqCapital { get; init; }
    public int ReqLength { get; init; }
    public bool ReqLower { get; init; }
    public bool ReqNotUsername { get; init; }
    public bool ReqNumber { get; init; }
    public bool ReqSymbol { get; init; }
    public bool ReqNotCommon { get; init; }
    public bool ReqNotPreviouslyUsed { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
