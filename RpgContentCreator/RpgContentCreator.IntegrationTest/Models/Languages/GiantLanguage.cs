using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class GiantLanguage : LanguageModel
{
    public GiantLanguage(GameSystemModel gameSystem)
    {
        Name = "Gigante";
        Alphabet = "Anão";
        GameSystem = gameSystem;
    }
}