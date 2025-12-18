using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class DwarfLanguage : LanguageModel
{
    public DwarfLanguage(GameSystemModel gameSystem)
    {
        Name = "Anão";
        Alphabet = "Anão";
        GameSystem = gameSystem;
    }
}