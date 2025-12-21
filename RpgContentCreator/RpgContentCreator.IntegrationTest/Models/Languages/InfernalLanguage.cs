using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class InfernalLanguage : LanguageModel
{
    public InfernalLanguage( GameSystemRules rules )
    {
        Name = "Infernal";
        Alphabet = "Infernal";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}