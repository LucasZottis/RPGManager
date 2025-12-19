using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class GnomishLanguage : LanguageModel
{
    public GnomishLanguage(GameSystemModel gameSystem)
    {
        Name = "Gnômico";
        Alphabet = "Anão";
        GameSystem = gameSystem;
    }
}
