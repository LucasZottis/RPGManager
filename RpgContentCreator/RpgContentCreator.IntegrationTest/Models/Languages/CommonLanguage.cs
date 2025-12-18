using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class CommonLanguage : LanguageModel
{
    public CommonLanguage(GameSystemModel gameSystem)
    {
        Name = "Comum";
        Alphabet = "Alfabeto comum";
        GameSystem = gameSystem;
    }
}