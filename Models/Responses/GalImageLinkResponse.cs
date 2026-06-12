#nullable enable
namespace SmarterMail.Net.Models.Responses;

public record GalImageLinkResponse
{
    public string? ImageLink { get; init; }
    public bool Success { get; init; }
    public int ResultCode { get; init; }
}
