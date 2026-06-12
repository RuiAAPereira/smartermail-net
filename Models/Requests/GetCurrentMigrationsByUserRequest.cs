
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record GetCurrentMigrationsByUserRequest
{
    public string? Email { get; init; }
}
