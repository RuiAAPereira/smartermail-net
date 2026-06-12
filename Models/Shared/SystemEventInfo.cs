// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "evnt" sub-object returned by the get event by GUID endpoint.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record SystemEventInfo
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
    public ConditionInputType InputType { get; init; }
    public string? Key { get; init; }
    public string? PrefillKey { get; init; }
    public bool Required { get; init; }
    public EventRequirements Requirements { get; init; }
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
    public EventRequirements Requires { get; init; }
    public bool ShowVariables { get; init; }
    public bool DidTrigger { get; init; }
    public ActionRecipientType RecipientType { get; init; }
    public ActionRecipientType SupportedActionRecipients { get; init; }
}
