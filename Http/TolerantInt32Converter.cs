using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Http;

/// <summary>
/// Reads an <see cref="int"/> tolerantly from JSON. SmarterMail returns some
/// integer fields inconsistently — as a JSON number, as a quoted string, or as
/// an empty string / null when unset (e.g. userData.lastAcceptedPolicyVersion
/// for a never-accepted policy). Without this, deserialization throws
/// JsonException and crashes consumers. Number and string-number parse to their
/// value; empty, whitespace, and null map to 0. Writing always emits a number.
/// </summary>
public sealed class TolerantInt32Converter : JsonConverter<int>
{
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.Number:
                return reader.GetInt32();
            case JsonTokenType.Null:
                return 0;
            case JsonTokenType.String:
                var s = reader.GetString();
                if (string.IsNullOrWhiteSpace(s))
                    return 0;
                if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
                    return parsed;
                throw new JsonException($"Cannot convert string \"{s}\" to Int32.");
            default:
                throw new JsonException($"Unexpected token {reader.TokenType} when reading Int32.");
        }
    }

    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        => writer.WriteNumberValue(value);
}
