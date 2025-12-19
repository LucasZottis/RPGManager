using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class InfernalLanguage : LanguageModel
{
    public InfernalLanguage( GameSystemModel gameSystem )
    {
        Name = "Infernal";
        Alphabet = "Infernal";
        GameSystem = gameSystem;
    }
}