using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class UndercommonLanguage : LanguageModel
{
    public UndercommonLanguage( GameSystemRules rules )
    {
        Name = "Subcomum";
        Alphabet = "Élfico";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}