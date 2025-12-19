using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class GoblinLanguage : LanguageModel
{
    public GoblinLanguage( GameSystemModel gameSystem )
    {
        Name = "Goblin";
        Alphabet = "Anão";
        GameSystem = gameSystem;
    }
}