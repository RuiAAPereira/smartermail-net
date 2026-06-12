
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetActiveDirectoryUsersResponse
{
    public string? Id { get; init; }
    public string? MappedField { get; init; }
    public bool HideFromLdap { get; init; }
    public bool IsAlias { get; init; }
    public string? Name { get; init; }
    public bool Master { get; init; }
    public int Index { get; init; }
    public int PhotoVersion { get; init; }
    public string? Number { get; init; }
    public string? JobTitle { get; init; }
    public string? Company { get; init; }
    public string? Im { get; init; }
    public string? Im2 { get; init; }
    public string? Im3 { get; init; }
    public string? WebPage { get; init; }
    public string? BirthDate { get; init; }
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
    public string? Nickname { get; init; }
    public string? Initials { get; init; }
    public string? DisplayAs { get; init; }
    public string? Title { get; init; }
    public string? Suffix { get; init; }
    public string? CompanyUrl { get; init; }
    public string? CompanyDepartment { get; init; }
    public string? CompanyOffice { get; init; }
    public string? AdditionalInfo { get; init; }
    public bool IsHtml { get; init; }
    public JsonElement? Picture { get; init; }
    public string? Username { get; init; }
    public string? GalAddress { get; init; }
    public string? Image { get; init; }
    public bool HasImage { get; init; }
    public string? SourceOwner { get; init; }
    public string? SourceId { get; init; }
    public string? AssistantName { get; init; }
    public string? ManagerName { get; init; }
    public string? Mileage { get; init; }
    public string? Profession { get; init; }
    public string? SpouseName { get; init; }
    public string? WeddingAnniversary { get; init; }
    public string? PostalAddressIndex { get; init; }
    public string? YomiFirstName { get; init; }
    public string? YomiLastName { get; init; }
    public string? FileAs { get; init; }
    public string? FileAsMappingType { get; init; }
    public JsonElement? Children { get; init; }
    public DateTime? LastModifiedUtc { get; init; }
    public string? FullName { get; init; }
    public string? Email { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
