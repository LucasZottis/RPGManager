using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class DraconicLanguage : LanguageModel
{
    public DraconicLanguage( GameSystemModel gameSystem )
    {
        Name = "Dracônico";
        Alphabet = "Dracônico";
        GameSystem = gameSystem;
    }
}