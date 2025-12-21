using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class PrimordialLanguage : LanguageModel
{
    public PrimordialLanguage( GameSystemRules rules )
    {
        Name = "Primordial";
        Alphabet = "Dracônico";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}