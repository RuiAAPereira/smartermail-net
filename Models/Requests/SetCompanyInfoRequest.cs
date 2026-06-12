
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record SetCompanyInfoRequest
{
    public JsonElement? CompanyInfo { get; init; }
    public DateTime? CreationDate { get; init; }
    public string? HtmlDisplayBadge { get; init; }
    public bool ShowLoginAreaHTML { get; init; }
    public string? LogoImage { get; init; }
    public SmarterMail.Net.Models.Enums.LoginBackgroundOptions LoginBackgroundOption { get; init; }
    public string? LoginBackgroundImagePath { get; init; }
    public string? LoginBackgroundColor { get; init; }
    public string? CustomHelpText { get; init; }
    public string? CustomHelpLink { get; init; }
    public bool CustomHelpLinkEnabled { get; init; }
    public string? CustomLoginText { get; init; }
    public bool CustomLoginTextEnabled { get; init; }
    public string? CompanyInfoPath { get; init; }
    public string? CustomTitleText { get; init; }
}
