using RpgContentCreator.Domain.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class SylvanLanguage : LanguageModel
{
    public SylvanLanguage( GameSystemRules rules )
    {
        Name = "Silvestre";
        Alphabet = "Élfico";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}