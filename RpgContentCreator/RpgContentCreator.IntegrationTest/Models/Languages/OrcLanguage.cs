using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class OrcLanguage : LanguageModel
{
    public OrcLanguage( GameSystemModel gameSystem )
    {
        Name = "Orc";
        Alphabet = "Anão";
        GameSystem = gameSystem;
    }
}