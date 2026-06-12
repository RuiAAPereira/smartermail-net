namespace SmarterMail.Net.Models.Shared;

public record EmailAddressInfo
{
    public string? Name { get; init; }
    public string? Address { get; init; }
}