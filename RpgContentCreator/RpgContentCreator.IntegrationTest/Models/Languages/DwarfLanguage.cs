using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class DwarfLanguage : LanguageModel
{
    public DwarfLanguage( GameSystemRules rules )
    {
        Name = "Anão";
        Alphabet = "Anão";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}