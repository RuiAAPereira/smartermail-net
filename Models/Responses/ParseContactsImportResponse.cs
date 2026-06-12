#nullable enable

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmarterMail.Net.Models.Responses;

/// <summary>
/// Response returned by POST /api/upload with context=contact-import.
/// The server parses a CSV or VCF file and returns the contacts it found, without committing them.
/// </summary>
public record ParseContactsImportResponse
{
    /// <summary>Parsed contacts from the uploaded file.</summary>
    public IReadOnlyList<ParsedImportContact>? Contacts { get; init; }

    /// <summary>Indicates whether the parse operation succeeded.</summary>
    public bool Success { get; init; }

    /// <summary>Optional diagnostic message returned by the server for troubleshooting parse failures.</summary>
    public string? DebugInfo { get; init; }

    /// <summary>Catch-all for any top-level fields not yet modeled.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}

/// <summary>A single contact parsed from an import file.</summary>
public record ParsedImportContact
{
    /// <summary>Display name of the contact as parsed from the import file.</summary>
    public string? DisplayAs { get; init; }

    /// <summary>All email addresses associated with the contact (may contain multiple entries).</summary>
    public IReadOnlyList<string>? EmailAddressList { get; init; }

    /// <summary>Primary email address of the contact.</summary>
    public string? Email { get; init; }

    /// <summary>Contact type discriminator (e.g. 0 = person, 1 = group) as returned by the server.</summary>
    public int? ContactType { get; init; }

    /// <summary>CSV field mappings — populated for CSV imports only.</summary>
    public IReadOnlyList<CsvImportField>? CsvFields { get; init; }

    /// <summary>Catch-all for any contact-level fields not yet modeled.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}

/// <summary>A single CSV column mapping entry returned by the server for CSV imports.</summary>
public record CsvImportField
{
    /// <summary>Server-assigned identifier for this CSV field mapping row.</summary>
    public string? Id { get; init; }

    /// <summary>SmarterMail contact field name that this CSV column was mapped to (e.g. "displayas", "emailaddress").</summary>
    public string? MappedField { get; init; }

    /// <summary>Original CSV column header as it appeared in the uploaded file.</summary>
    public string? UploadedField { get; init; }

    /// <summary>Parsed cell value from the CSV row for this field.</summary>
    public string? Value { get; init; }
}
