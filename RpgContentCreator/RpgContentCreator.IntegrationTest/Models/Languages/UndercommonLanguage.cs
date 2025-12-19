using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class UndercommonLanguage : LanguageModel
{
    public UndercommonLanguage(GameSystemModel gameSystem)
    {
        Name = "Subcomum";
        Alphabet = "Élfico";
        GameSystem = gameSystem;
    }
}