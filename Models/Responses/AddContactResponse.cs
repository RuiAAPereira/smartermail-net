
#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record AddContactResponse
{
    public List<ContactInfo>? Contacts { get; init; }
    public bool HideFromLdap { get; init; }
    public bool IsAlias { get; init; }
    public string? Name { get; init; }
    public bool Master { get; init; }
    public int PhotoVersion { get; init; }
    public string? Number { get; init; }
    public string? JobTitle { get; init; }
    public string? Company { get; init; }
    public string? Im { get; init; }
    public string? Im2 { get; init; }
    public string? Im3 { get; init; }
    public string? WebPage { get; init; }
    public DateTime? BirthDate { get; init; }
    public string? HomeCountry { get; init; }
    public string? HomeState { get; init; }
    public string? HomeCity { get; init; }
    public string? HomeStreet { get; init; }
    public string? HomeZip { get; init; }
    public string? OtherCountry { get; init; }
    public string? OtherState { get; init; }
    public string? OtherCity { get; init; }
    public string? OtherStreet { get; init; }
    public string? OtherZip { get; init; }
    public string? BusCountry { get; init; }
    public string? BusState { get; init; }
    public string? BusCity { get; init; }
    public string? BusStreet { get; init; }
    public string? BusZip { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? MiddleName { get; init; }
    public string? DisplayAs { get; init; }
    public string? Title { get; init; }
    public string? Suffix { get; init; }
    public string? CompanyUrl { get; init; }
    public string? CompanyDepartment { get; init; }
    public string? CompanyOffice { get; init; }
    public string? AdditionalInfo { get; init; }
    public JsonElement? Picture { get; init; }
    public string? Username { get; init; }
    public string? GalAddress { get; init; }
    public string? Image { get; init; }
    public JsonElement? CsvFields { get; init; }
    public string? Id { get; init; }
    public string? MappedField { get; init; }
    public string? SourceOwner { get; init; }
    public string? SourceId { get; init; }
    public string? SourceName { get; init; }
    public JsonElement? FlagInfo { get; init; }
    public DateTime? LastModifiedUtc { get; init; }
    public bool IsMailingList { get; init; }
    public string? FullName { get; init; }
    public string? EmailAddress { get; init; }
    public string? NameAndEmail { get; init; }
    public string? DebugInfo { get; init; }
    public bool Success { get; init; }
}
