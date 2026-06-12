
#nullable enable

using System.Text.Json;

namespace SmarterMail.Net.Models.Requests;

public record AddEventHookRequest
{
    public bool Constrained { get; init; }
    public string? ConstraintFrequency { get; init; }
    public string? ConstraintKey { get; init; }
    public int DefaultFrequencyInMinutes { get; init; }
    public long EventActionID { get; init; }
    public JsonElement? Inputs { get; init; }
    public string? DescriptionResourceId { get; init; }
    public bool Hidden { get; init; }
    public SmarterMail.Net.Models.Enums.ConditionInputType InputType { get; init; }
    public string? Key { get; init; }
    public string? PrefillKey { get; init; }
    public bool Required { get; init; }
    public JsonElement? LastOccuredMapping { get; init; }
    public DateTime? LastOccuredUTC { get; init; }
    public SmarterMail.Net.Models.Enums.EventRequirements Requires { get; init; }
    public bool ShowVariables { get; init; }
    public bool DidTrigger { get; init; }
    public SmarterMail.Net.Models.Enums.ActionRecipientType RecipientType { get; init; }
    public SmarterMail.Net.Models.Enums.ActionRecipientType SupportedActionRecipients { get; init; }
    public string? Id { get; init; }
    public JsonElement? LastInput { get; init; }
}
