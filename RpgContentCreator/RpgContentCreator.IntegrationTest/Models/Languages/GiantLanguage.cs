using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class GiantLanguage : LanguageModel
{
    public GiantLanguage( GameSystemRules rules )
    {
        Name = "Gigante";
        Alphabet = "Anão";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}