using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Http;

/// <summary>Centralized JSON serializer configuration for the SmarterMail SDK.</summary>
public static class SmarterMailJsonOptions
{
    /// <summary>
    /// Shared options: camelCase, case-insensitive matching, nulls omitted,
    /// string enum conversion.
    /// </summary>
    public static readonly JsonSerializerOptions Default = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
    };
}
