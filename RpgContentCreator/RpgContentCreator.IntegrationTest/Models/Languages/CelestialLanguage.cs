using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class CelestialLanguage : LanguageModel
{
    public CelestialLanguage( GameSystemModel gameSystem )
    {
        Name = "Celestial";
        Alphabet = "Celestial";
        GameSystem = gameSystem
    }
}