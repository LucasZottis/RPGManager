



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.UNDER_COMMON )]
public class UndercommonLanguage : LanguageModel
{
    public UndercommonLanguage( Dictionaries rules )
    {
        Name = "Subcomum";
        Alphabet = "Élfico";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}