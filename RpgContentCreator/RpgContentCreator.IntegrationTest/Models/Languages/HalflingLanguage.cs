using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class HalflingLanguage : LanguageModel
{
    public HalflingLanguage( GameSystemRules rules )
    {
        Name = "Halfling";
        Alphabet = "Comum";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}