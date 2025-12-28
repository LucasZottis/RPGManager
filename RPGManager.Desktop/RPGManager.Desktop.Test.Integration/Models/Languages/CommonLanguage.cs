namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.COMMON )]
public class CommonLanguage : LanguageModel
{
    public CommonLanguage( Dictionaries rules )
    {
        Name = "Comum";
        Alphabet = "Comum";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}