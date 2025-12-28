namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.DEEP_SPEECH )]
public class DeepSpeechLanguage : LanguageModel
{
    public DeepSpeechLanguage( Dictionaries rules )
    {
        Name = "Dialeto Profundo";
        Alphabet = null;
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}