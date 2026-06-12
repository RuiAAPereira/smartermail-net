
namespace SmarterMail.Net.Models.Enums;

[Flags]
public enum InternalSpamAssassinHeaderLogOption
{
    Score = 0,
    ScoreAndTestName = 1,
    ScoreAndTestNameAndDescription = 2,
}
