// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "companyInfo" sub-object returned by the company info endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record CompanyInfoDetails
{
    public DateTime? CreationDate { get; init; }
    public string? HtmlDisplayBadge { get; init; }
    public bool ShowLoginAreaHTML { get; init; }
    public string? LogoImage { get; init; }
    public LoginBackgroundOptions LoginBackgroundOption { get; init; }
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
