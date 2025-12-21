using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class CommonLanguage : LanguageModel
{
    public CommonLanguage( GameSystemRules rules )
    {
        Name = "Comum";
        Alphabet = "Comum";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}