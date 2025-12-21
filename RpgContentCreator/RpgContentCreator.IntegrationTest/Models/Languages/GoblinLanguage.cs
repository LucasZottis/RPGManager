using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class GoblinLanguage : LanguageModel
{
    public GoblinLanguage( GameSystemRules rules )
    {
        Name = "Goblin";
        Alphabet = "Anão";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}