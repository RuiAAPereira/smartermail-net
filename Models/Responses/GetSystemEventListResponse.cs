// MANUALLY PATCHED — do not overwrite with model generator output.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Shared;

namespace SmarterMail.Net.Models.Responses;

public record GetSystemEventListResponse
{
    public bool AllowReset { get; init; }
    public JsonElement? Arguments { get; init; }
    public string? DescriptionResourceId { get; init; }
    public string? CategoryResourceId { get; init; }
    public JsonElement? Conditions { get; init; }
    public bool AffectsReset { get; init; }
    public string? DescriptionResourceID { get; init; }
    public bool Hidden { get; init; }
    public bool Ignore { get; init; }
    public SmarterMail.Net.Models.Enums.ConditionInputType InputType { get; init; }
    public string? Key { get; init; }
    public string? PrefillKey { get; init; }
    public bool Required { get; init; }
    public SmarterMail.Net.Models.Enums.EventRequirements Requirements { get; init; }
    public bool ShowInVariablesList { get; init; }
    public JsonElement? Value1 { get; init; }
    public JsonElement? Value2 { get; init; }
    public string? Condition { get; init; }
    public int DefaultFrequency { get; init; }
    public long EventId { get; init; }
    public string? Id { get; init; }
    public int MinFrequency { get; init; }
    public string? NameResourceId { get; init; }
    public JsonElement? PossibleActions { get; init; }
    public bool Constrained { get; init; }
    public string? ConstraintFrequency { get; init; }
    public string? ConstraintKey { get; init; }
    public int DefaultFrequencyInMinutes { get; init; }
    public long EventActionID { get; init; }
    public JsonElement? Inputs { get; init; }
    public JsonElement? LastOccuredMapping { get; init; }
    public DateTime? LastOccuredUTC { get; init; }
    public SmarterMail.Net.Models.Enums.EventRequirements Requires { get; init; }
    public bool ShowVariables { get; init; }
    public bool DidTrigger { get; init; }
    public SmarterMail.Net.Models.Enums.ActionRecipientType RecipientType { get; init; }
    public SmarterMail.Net.Models.Enums.ActionRecipientType SupportedActionRecipients { get; init; }
    public EventInputInfo? LastInput { get; init; }
    public bool Success { get; init; }
    public string? Message { get; init; }
    public JsonElement? Variables { get; init; }
}
