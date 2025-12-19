using RpgContentCreator.Application.Models;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class PrimordialLanguage : LanguageModel
{
    public PrimordialLanguage( GameSystemModel gameSystem )
    {
        Name = "Primordial";
        Alphabet = "Dracônico";
        GameSystem = gameSystem;
    }
}