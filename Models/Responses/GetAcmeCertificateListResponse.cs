
#nullable enable

using System;
using System.Text.Json;

namespace SmarterMail.Net.Models.Responses;

public record GetAcmeCertificateListResponse
{
    public JsonElement? Certificates { get; init; }
    public string? Guid { get; init; }
    public string? Hostname { get; init; }
    public string? Associated_domain { get; init; }
    public bool Is_accessible { get; init; }
    public bool Is_disabled { get; init; }
    public SmarterMail.Net.Models.Enums.AcmeValidationStatuses Acme_validation_status { get; init; }
    public SmarterMail.Net.Models.Enums.AcmeCombinedStatus Combined_status { get; init; }
    public SmarterMail.Net.Models.Enums.AcmeProviders Acme_provider { get; init; }
    public string? Binding_error { get; init; }
    public DateTime? Expires_utc { get; init; }
    public DateTime? Generated_utc { get; init; }
    public DateTime? Next_validation_check_utc { get; init; }
    public DateTime? Renews_utc { get; init; }
    public bool IsExpired { get; init; }
    public string? Acme_error_message { get; init; }
    public bool Acme_enabled { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
