using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class OrcLanguage : LanguageModel
{
    public OrcLanguage( GameSystemRules rules )
    {
        Name = "Orc";
        Alphabet = "Anão";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}