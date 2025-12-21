using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class GnomishLanguage : LanguageModel
{
    public GnomishLanguage( GameSystemRules rules )
    {
        Name = "Gnômico";
        Alphabet = "Anão";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}
