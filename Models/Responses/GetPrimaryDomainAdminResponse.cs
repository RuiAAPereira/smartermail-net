// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetPrimaryDomainAdminResponse
{
    public UserDataInfo? UserData { get; init; }
    public string? SessionStr { get; init; }
    public JsonElement? CsvFields { get; init; }
    public string? Id { get; init; }
    public string? MappedField { get; init; }
    public bool IsPasswordExpired { get; init; }
    public PasswordRequirementFlags IsPasswordCompliant { get; init; }
    public string? UserName { get; init; }
    public string? AdUsername { get; init; }
    public long MaxMailboxSize { get; init; }
    public bool IsPrimaryDomainAdmin { get; init; }
    public string? AuthType { get; init; }
    public DateTime? LastLoginTime { get; init; }
    public JsonElement? Roles { get; init; }
    public string? EmailAddress { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}