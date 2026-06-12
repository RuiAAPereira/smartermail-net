#nullable enable

using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Shared;

/// <summary>The SmarterMail timezone-aware date/time shape used by calendar events
/// (both read-side <c>startWithTZ</c>/<c>endWithTZ</c> and write-side <c>start</c>/<c>end</c>).</summary>
public record EventDateTime
{
    private string? _dateLocal;
    private string? _timeZoneId;

    [JsonPropertyName("dt")]
    public string? DateLocal
    {
        get => _dateLocal;
        init => _dateLocal = value;
    }

    [JsonPropertyName("tz")]
    public string? TimeZoneId
    {
        get => _timeZoneId;
        init => _timeZoneId = value;
    }

    [JsonPropertyName("has_time")]
    public bool HasTime { get; init; }

    [JsonPropertyName("date_local")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LegacyDateLocal
    {
        get => null;
        init
        {
            if (_dateLocal is null) _dateLocal = value;
        }
    }

    [JsonPropertyName("time_zone_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LegacyTimeZoneId
    {
        get => null;
        init
        {
            if (_timeZoneId is null) _timeZoneId = value;
        }
    }
}
