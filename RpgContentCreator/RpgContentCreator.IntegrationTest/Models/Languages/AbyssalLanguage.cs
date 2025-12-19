using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class AbyssalLanguage : LanguageModel
{
    public AbyssalLanguage( GameSystemModel gameSystem )
    {
        Name = "Abissal";
        Alphabet = "Infernal";
        GameSystem = gameSystem;
    }
}