using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class SylvanLanguage : LanguageModel
{
    public SylvanLanguage( GameSystemModel gameSystem )
    {
        Name = "Silvestre";
        Alphabet = "Élfico";
        GameSystem = gameSystem;
    }
}