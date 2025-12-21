using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class DraconicLanguage : LanguageModel
{
    public DraconicLanguage( GameSystemRules rules )
    {
        Name = "Dracônico";
        Alphabet = "Dracônico";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}