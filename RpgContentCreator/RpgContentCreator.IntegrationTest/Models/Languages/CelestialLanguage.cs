using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class CelestialLanguage : LanguageModel
{
    public CelestialLanguage( GameSystemRules rules )
    {
        Name = "Celestial";
        Alphabet = "Celestial";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}