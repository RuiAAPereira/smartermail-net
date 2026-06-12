// MANUALLY PATCHED — do not overwrite with model generator output.
// Represents the "lastInput" sub-object returned by system event endpoints.
// Re-apply this file if models are regenerated.

#nullable enable

using System.Text.Json;
using SmarterMail.Net.Models.Enums;

namespace SmarterMail.Net.Models.Shared;

public record EventInputInfo
{
    public string? DescriptionResourceId { get; init; }
    public bool Hidden { get; init; }
    public ConditionInputType InputType { get; init; }
    public string? Key { get; init; }
    public string? PrefillKey { get; init; }
    public bool Required { get; init; }
    public EventRequirements Requirements { get; init; }
    public JsonElement? LastCondition { get; init; }
    public bool AffectsReset { get; init; }
    public string? DescriptionResourceID { get; init; }
    public bool Ignore { get; init; }
    public bool ShowInVariablesList { get; init; }
    public JsonElement? Value1 { get; init; }
}
