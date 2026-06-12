
#nullable enable

using System;
using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetShareUsersRequest
{
    public string? AdminId { get; init; }
    public string? CreateDate { get; init; }
    public string? Description { get; init; }
    public string? Domain { get; init; }
    public string? FullName { get; init; }
    public bool IsListModerator { get; init; }
    public int LastAcceptedPolicyVersion { get; init; }
    public JsonElement? Loaded { get; init; }
    public string? Password { get; init; }
    public string? TempPassword { get; init; }
    public DateTime? TempPasswordExpUtc { get; init; }
    public bool PasswordLocked { get; init; }
    public SmarterMail.Net.Models.Enums.UserServicePermissions Permissions { get; init; }
    public JsonElement? SecurityFlags { get; init; }
    public string? SessionStr { get; init; }
    public JsonElement? CsvFields { get; init; }
    public string? Id { get; init; }
    public string? MappedField { get; init; }
    public bool IsPasswordExpired { get; init; }
    public SmarterMail.Net.Models.Enums.PasswordRequirementFlags IsPasswordCompliant { get; init; }
    public string? UserName { get; init; }
    public string? AdUsername { get; init; }
    public long MaxMailboxSize { get; init; }
    public bool IsPrimaryDomainAdmin { get; init; }
    public string? AuthType { get; init; }
    public DateTime? LastLoginTime { get; init; }
    public JsonElement? Roles { get; init; }
    public string? EmailAddress { get; init; }
}
