using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class HalflingLanguage : LanguageModel
{
    public HalflingLanguage( GameSystemModel gameSystem )
    {
        Name = "Halfling";
        Alphabet = "Comum";
        GameSystem = gameSystem;
    }
}