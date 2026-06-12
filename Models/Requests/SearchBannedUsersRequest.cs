
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SearchBannedUsersRequest
{
    public int Skip { get; init; }
    public int Take { get; init; }
}
