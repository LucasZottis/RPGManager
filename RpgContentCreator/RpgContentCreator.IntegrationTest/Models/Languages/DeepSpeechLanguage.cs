using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class DeepSpeechLanguage : LanguageModel
{
    public DeepSpeechLanguage( GameSystemModel gameSystem )
    {
        Name = "Dialeto Profundo";
        Alphabet = null;
        GameSystem = gameSystem;
    }
}