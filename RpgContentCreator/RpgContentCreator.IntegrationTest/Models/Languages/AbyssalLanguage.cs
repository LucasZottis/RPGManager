using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class AbyssalLanguage : LanguageModel
{
    public AbyssalLanguage( GameSystemRules rules )
    {
        Name = "Abissal";
        Alphabet = "Infernal";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}