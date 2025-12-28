



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.HALFLING )]
public class HalflingLanguage : LanguageModel
{
    public HalflingLanguage( Dictionaries rules )
    {
        Name = "Halfling";
        Alphabet = "Comum";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}