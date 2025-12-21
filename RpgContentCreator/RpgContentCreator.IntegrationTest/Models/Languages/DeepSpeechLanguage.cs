using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;

namespace RpgContentCreator.IntegrationTest.Models.Languages;

public class DeepSpeechLanguage : LanguageModel
{
    public DeepSpeechLanguage( GameSystemRules rules )
    {
        Name = "Dialeto Profundo";
        Alphabet = null;
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}