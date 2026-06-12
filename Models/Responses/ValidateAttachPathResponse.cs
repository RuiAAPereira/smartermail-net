
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record ValidateAttachPathResponse
{
    public JsonElement? Items { get; init; }
    public string? DomainName { get; init; }
    public string? DomainPath { get; init; }
    public bool CanAttach { get; init; }
    public string? CannotAttachReason { get; init; }
    public bool NeedsMessageArchivePath { get; init; }
    public bool IsSplit { get; init; }
    public bool HasSecondaryStorage { get; init; }
    public string? MessageArchivePath { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
